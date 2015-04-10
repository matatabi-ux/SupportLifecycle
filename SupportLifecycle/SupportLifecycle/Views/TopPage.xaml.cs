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
using Xamarin.Forms;

namespace SupportLifecycle.Views
{
    /// <summary>
    /// トップ画面
    /// </summary>
    public partial class TopPage : ContentPage
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TopPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 画面表示時の処理
        /// </summary>
        protected override void OnAppearing()
        {
            SimpleLogger.WriteLine("TopPage Appearing.");

            base.OnAppearing();
        }

        /// <summary>
        /// ボタンタップ時の処理
        /// </summary>
        /// <param name="sender">イベント発行者</param>
        /// <param name="e">イベント引数</param>
        private async void OnButtonClicked(object sender, EventArgs e)
        {
            var navPage = App.Current.MainPage as NavigationPage;

            if (navPage == null)
            {
                return;
            }
            await navPage.PushAsync(new SecondPage());
        }
    }
}
