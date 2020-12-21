using System;
using Acr.UserDialogs;
using Android.App;
using Android.Runtime;
using AcrDemo.Core;
using MvvmCross.IoC;
using MvvmCross.Platforms.Android;
using MvvmCross.Platforms.Android.Views;
using Plugin.CurrentActivity;

namespace AcrDemo.Droid
{
#if DEBUG
    [Application(Debuggable = true)]
#else
    [Application(Debuggable = false)]
#endif
    public class MainApplication : MvxAndroidApplication<Setup, App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            UserDialogs.Init(() => MvxIoCProvider.Instance.Resolve<IMvxAndroidCurrentTopActivity>().Activity);
            CrossCurrentActivity.Current.Init(this);
        }
    }
}
