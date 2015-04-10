#region License
//-----------------------------------------------------------------------
// <copyright>
//     Copyright matatabi-ux 2015.
// </copyright>
//-----------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using SupportLifecycle.Services;
using Xamarin.Forms;

namespace SupportLifecycle.Views
{
    /// <summary>
    /// 二番目の画面
    /// </summary>
    public partial class SecondPage : ContentPage
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SecondPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 画面表示時の処理
        /// </summary>
        protected override void OnAppearing()
        {
            SimpleLogger.WriteLine("SecondPage Appearing.");

            base.OnAppearing();
        }

        /// <summary>
        /// ボタンタップ時の処理
        /// </summary>
        /// <param name="sender">イベント発行者</param>
        /// <param name="e">イベント引数</param>
        private void OnButtonClicked(object sender, EventArgs e)
        {
            App.Container.Resolve<IOpenBrowserService>().OpenUri(@"http://www.xamarin.com");
        }
    }
}
