using AcrDemo.Core;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Converters;
using MvvmCross.IoC;
using MvvmCross.Localization;
using MvvmCross.Platforms.Android.Core;

namespace AcrDemo.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {
        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            base.FillTargetFactories(registry);
        }
        protected override void FillValueConverters(IMvxValueConverterRegistry registry)
        {
            base.FillValueConverters(registry);
            registry.AddOrOverwrite("Language", new MvxLanguageConverter());
        }
        protected override IMvxIoCProvider InitializeIoC()
        {
            var provider = base.InitializeIoC();


            return provider;
        }
    }
}

