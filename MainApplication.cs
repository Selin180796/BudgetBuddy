using System;
using Android.App;
using Android.Runtime;

namespace BudgetBuddy.Android
{
    [Application]
    public class MainApplication : Application
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership) : base(handle, ownership)
        {
        }
    }
}
