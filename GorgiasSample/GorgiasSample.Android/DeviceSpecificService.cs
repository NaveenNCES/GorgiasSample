using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GorgiasSample.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceSpecificService))]
namespace GorgiasSample.Droid
{
    public class DeviceSpecificService : IDeviceSpecificService
    {
        public void ClearCookies()
        {
            Android.Webkit.CookieManager.Instance.RemoveAllCookie();
        }
    }
}