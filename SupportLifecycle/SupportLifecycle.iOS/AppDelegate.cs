using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Microsoft.Practices.Unity;
using SupportLifecycle.iOS.Services;
using SupportLifecycle.Services;
using UIKit;

namespace SupportLifecycle.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        /// <summary>
        /// WillFinishLanching イベントハンドラ
        /// 起動プロセスは実行されたが、その状態の復元がまだ発生していない状態
        /// </summary>
        /// <param name="uiApplication">アプリケーション</param>
        /// <param name="launchOptions">起動オプション</param>
        /// <returns>正常終了フラグ</returns>
        public override bool WillFinishLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            SimpleLogger.WriteLine(string.Format("WillFinishLaunching. AppState={0}", uiApplication.ApplicationState.ToString()));

            // ブラウザで開く機能を登録
            //App.Container.RegisterType<IOpenBrowserService, OpenBrowserService>(new ContainerControlledLifetimeManager());

            return base.WillFinishLaunching(uiApplication, launchOptions);
        }

        /// <summary>
        /// FinishedLaunching イベントハンドラ
        /// 起動プロセスがほぼ終了した後、アプリの起動準備ができた状態
        /// </summary>
        /// <param name="uiApplication">アプリケーション</param>
        /// <param name="launchOptions">起動オプション</param>
        /// <returns>正常終了フラグ</returns>
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            SimpleLogger.WriteLine(string.Format("FinishedLaunching. AppState={0}", uiApplication.ApplicationState.ToString()));

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(uiApplication, launchOptions);
        }

        /// <summary>
        /// OnResignActivation イベントハンドラ
        /// アプリケーションがアクティブになる直前に呼び出されます
        /// </summary>
        /// <param name="uiApplication">アプリケーション</param>
        public override void OnResignActivation(UIApplication uiApplication)
        {
            SimpleLogger.WriteLine(string.Format("OnResignActivation. AppState={0}", uiApplication.ApplicationState.ToString()));

            base.OnResignActivation(uiApplication);
        }

        /// <summary>
        /// OnActivated イベントハンドラ
        /// アプリケーションがアクティブになった直後に呼び出されます
        /// </summary>
        /// <param name="uiApplication">アプリケーション</param>
        public override void OnActivated(UIApplication uiApplication)
        {
            SimpleLogger.WriteLine(string.Format("OnActivated. AppState={0}", uiApplication.ApplicationState.ToString()));

            base.OnActivated(uiApplication);
        }

        /// <summary>
        /// DidEnterBackground イベントハンドラ
        /// Backgrond 状態に遷移した状態
        /// </summary>
        /// <param name="uiApplication">アプリケーション</param>
        public override void DidEnterBackground(UIApplication uiApplication)
        {
            SimpleLogger.WriteLine(string.Format("DidEnterBackground. AppState={0}", uiApplication.ApplicationState.ToString()));

            base.DidEnterBackground(uiApplication);
        }

        /// <summary>
        /// WillEncodeRestorableState イベントハンドラ
        /// 任意のアプリデータ復帰が必要になった場合に呼び出されます
        /// </summary>
        /// <param name="uiApplication">アプリケーション</param>
        /// <param name="coder">シリアライズオブジェクト</param>
        public override void WillEncodeRestorableState(UIApplication uiApplication, NSCoder coder)
        {
            SimpleLogger.WriteLine(string.Format("WillEncodeRestorableState. AppState={0}", uiApplication.ApplicationState.ToString()));

            base.WillEncodeRestorableState(uiApplication, coder);
        }

        /// <summary>
        /// WillEnterForeground イベントハンドラ
        /// Foreground 状態に遷移した状態
        /// </summary>
        /// <param name="uiApplication">アプリケーション</param>
        public override void WillEnterForeground(UIApplication uiApplication)
        {
            SimpleLogger.WriteLine(string.Format("WillEnterForeground. AppState={0}", uiApplication.ApplicationState.ToString()));

            base.WillEnterForeground(uiApplication);
        }

        /// <summary>
        /// WillTerminate イベントハンドラ
        /// アプリが終了する直前に呼び出されます
        /// </summary>
        /// <param name="uiApplication">アプリケーション</param>
        public override void WillTerminate(UIApplication uiApplication)
        {
            SimpleLogger.WriteLine(string.Format("WillTerminate. AppState={0}", uiApplication.ApplicationState.ToString()));

            base.WillTerminate(uiApplication);
        }
    }
}
