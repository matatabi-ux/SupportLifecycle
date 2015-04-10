#region License
//-----------------------------------------------------------------------
// <copyright>
//     Copyright matatabi-ux 2015.
// </copyright>
//-----------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using SupportLifecycle.Services;
using SupportLifecycle.Views;
using Xamarin.Forms;

namespace SupportLifecycle
{
    /// <summary>
    /// アプリケーション基盤クラス
    /// </summary>
    public class App : Application
    {
        /// <summary>
        /// DI コンテナ
        /// </summary>
        public static UnityContainer Container = new UnityContainer();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public App()
        {
            this.MainPage = new NavigationPage(new TopPage());
            Container.RegisterType<IOpenBrowserService, OpenBrowserService>(new ContainerControlledLifetimeManager());
        }

        /// <summary>
        /// アプリ起動時処理
        /// </summary>
        protected override void OnStart()
        {
            SimpleLogger.WriteLine("started.");
        }

        /// <summary>
        /// アプリ中断時処理
        /// </summary>
        protected override void OnSleep()
        {
            SimpleLogger.WriteLine("sleeped.");
        }

        /// <summary>
        /// アプリ再開時処理
        /// </summary>
        protected override void OnResume()
        {
            SimpleLogger.WriteLine("resumed.");
        }
    }
}
