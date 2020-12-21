using Acr.UserDialogs;
using AcrDemo.Core.ViewModels.Main;
using MvvmCross.IoC;
using MvvmCross.Localization;
using MvvmCross.ViewModels;

namespace AcrDemo.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Repository")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            MvxIoCProvider.Instance.RegisterSingleton(() => UserDialogs.Instance);
           
            RegisterAppStart<MainViewModel>();
        }
    }
}
