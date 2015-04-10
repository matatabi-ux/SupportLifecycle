#region License
//-----------------------------------------------------------------------
// <copyright>
//     Copyright matatabi-ux 2015.
// </copyright>
//-----------------------------------------------------------------------
#endregion

using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.Practices.Unity;
using SupportLifecycle.Droid.Services;
using SupportLifecycle.Services;

namespace SupportLifecycle.Droid
{
    /// <summary>
    /// メイン Activity
    /// </summary>
    [Activity(Label = "SupportLifecycle", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, LaunchMode = LaunchMode.SingleTop)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        /// <summary>
        /// Create イベントハンドラ
        /// </summary>
        /// <param name="bundle">起動情報</param>
        protected override void OnCreate(Bundle bundle)
        {
            SimpleLogger.WriteLine("OnCreate.");

            // ブラウザで開く機能を登録
            //App.Container.RegisterType<IOpenBrowserService, OpenBrowserService>(new ContainerControlledLifetimeManager());

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        /// <summary>
        /// Start イベントハンドラ
        /// </summary>
        protected override void OnStart()
        {
            SimpleLogger.WriteLine("OnStart.");

            base.OnStart();
        }

        /// <summary>
        /// RestoreInstanceState イベントハンドラ
        /// </summary>
        /// <param name="savedInstanceState">一時保存情報</param>
        protected override void OnRestoreInstanceState(Bundle savedInstanceState)
        {
            SimpleLogger.WriteLine("OnRestoreInstanceState.");

            base.OnRestoreInstanceState(savedInstanceState);
        }

        /// <summary>
        /// PostCreate イベントハンドラ
        /// </summary>
        /// <param name="savedInstanceState">一時保存情報</param>
        protected override void OnPostCreate(Bundle savedInstanceState)
        {
            SimpleLogger.WriteLine("OnPostCreate.");

            base.OnPostCreate(savedInstanceState);
        }

        /// <summary>
        /// Resume イベントハンドラ
        /// </summary>
        protected override void OnResume()
        {
            SimpleLogger.WriteLine("OnResume.");

            base.OnResume();
        }

        /// <summary>
        /// PostResume イベントハンドラ
        /// </summary>
        protected override void OnPostResume()
        {
            SimpleLogger.WriteLine("OnPostResume.");

            base.OnPostResume();
        }

        /// <summary>
        /// UserLeaveHint イベントハンドラ
        /// </summary>
        protected override void OnUserLeaveHint()
        {
            SimpleLogger.WriteLine("OnUserLeaveHint.");

            base.OnUserLeaveHint();
        }

        /// <summary>
        /// SaveInstanceState イベントハンドラ
        /// </summary>
        /// <param name="outState">出力情報</param>
        protected override void OnSaveInstanceState(Bundle outState)
        {
            SimpleLogger.WriteLine("OnSaveInstanceState.");

            base.OnSaveInstanceState(outState);
        }

        /// <summary>
        /// CreateThumbnail イベントハンドラ
        /// </summary>
        /// <param name="outBitmap">出力画像</param>
        /// <param name="canvas">出力先</param>
        /// <returns>サムネイル生成結果</returns>
        public override bool OnCreateThumbnail(Bitmap outBitmap, Canvas canvas)
        {
            SimpleLogger.WriteLine("OnCreateThumbnail.");

            return base.OnCreateThumbnail(outBitmap, canvas);
        }

        /// <summary>
        /// Pause イベントハンドラ
        /// </summary>
        protected override void OnPause()
        {
            SimpleLogger.WriteLine("OnPause.");

            base.OnPause();
        }

        /// <summary>
        /// NewIntent イベントハンドラ
        /// </summary>
        protected override void OnNewIntent(Intent intent)
        {
            SimpleLogger.WriteLine("OnNewIntent.");

            base.OnNewIntent(intent);
        }

        /// <summary>
        /// Restart イベントハンドラ
        /// </summary>
        protected override void OnRestart()
        {
            SimpleLogger.WriteLine("OnRestart.");

            base.OnRestart();
        }

        /// <summary>
        /// Stop イベントハンドラ
        /// </summary>
        protected override void OnStop()
        {
            SimpleLogger.WriteLine("OnStop.");

            base.OnStop();
        }

        /// <summary>
        /// Destroy イベントハンドラ
        /// </summary>
        protected override void OnDestroy()
        {
            SimpleLogger.WriteLine("OnDestroy.");

            base.OnDestroy();
        }
    }
}

