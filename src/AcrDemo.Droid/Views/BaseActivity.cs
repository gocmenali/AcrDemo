
using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.ViewModels;

namespace AcrDemo.Droid.Views
{
    [Activity(
        Theme = "@style/AppTheme",
        ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait,
        WindowSoftInputMode = SoftInput.AdjustResize | SoftInput.StateHidden)]
    public abstract class BaseActivity<TViewModel> : MvxActivity<TViewModel>
        where TViewModel : class, IMvxViewModel
    {
        protected abstract int ActivityLayoutId { get; }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(ActivityLayoutId);
        }
    }
}
