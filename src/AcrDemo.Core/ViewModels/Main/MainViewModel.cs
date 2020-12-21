using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using MvvmCross.Commands;
using MvvmCross.IoC;
using MvvmCross.Localization;
using MvvmCross.Navigation;

namespace AcrDemo.Core.ViewModels.Main
{
    public class MainViewModel : BaseViewModel
    {
        public override void ViewCreated()
        {
            base.ViewCreated();

            var cfg = new PromptConfig()
                .SetInputMode(InputType.Name)
                .SetMaxLength(16)
                .SetCancellable(false)
                .SetCancelText("Cancel")
                .SetOkText("Ok")
                .SetMessage("Type your name")
                .SetPlaceholder("Name")
                .SetTitle("Type your name")
                .SetAction((promptResult) => {
                    System.Console.WriteLine("action result ***********************************************");
                    UserDialogs.Instance.Toast(new ToastConfig("Congrats"));
                });

            UserDialogs.Instance.Prompt(cfg);

        }
    }
}
