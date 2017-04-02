using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FFImageLoading;
using FFImageLoading.Config;
using FFImageLoading.Helpers;
using FFImageLoading.Work;
using MALClient.XShared.BL;
using MALClient.XShared.Comm.CommUtils;
using MALClient.XShared.Utils;
using MALClient.XShared.Utils.Managers;
using MALClient.XShared.ViewModels;

namespace MALClient.Android
{
    [Application]
    public class App : Application
    {
        public static App Current { get; private set; }

        public App(IntPtr handle, JniHandleOwnership ownerShip) : base(handle, ownerShip)
        {
            Current = this;
        }

        public override void OnCreate()
        {

            //ImageService.Instance.Initialize(new Configuration
            //{
            //    BitmapOptimizations = true,
            //    VerbosePerformanceLogging = true,
            //    Logger = new MiniLogger()
            //});
            ViewModelLocator.RegisterBase();
            AndroidViewModelLocator.RegisterDependencies();
            InitializationRoutines.InitApp();
            //ServicePointManager.ServerCertificateValidationCallback += (o, certificate, chain, errors) => true;
            
            base.OnCreate();
        }

       
    }
}