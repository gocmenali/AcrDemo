using MvvmCross.Localization;
using MvvmCross.ViewModels;

namespace AcrDemo.Core.ViewModels
{
    public abstract class BaseViewModel : MvxViewModel
    {
        public IMvxLanguageBinder TextSource => new MvxLanguageBinder("", GetType().Name);
        public IMvxTextProvider TextProvider { get; }
        protected BaseViewModel(IMvxTextProvider textProvider)
        {
            TextProvider = textProvider;
        }
        protected BaseViewModel() { }
        public string this[string key] => TextProvider.GetText("", "", key);
    }
}
