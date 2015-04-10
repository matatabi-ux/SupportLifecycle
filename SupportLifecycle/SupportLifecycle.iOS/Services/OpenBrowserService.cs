#region License
//-----------------------------------------------------------------------
// <copyright>
//     Copyright matatabi-ux 2015.
// </copyright>
//-----------------------------------------------------------------------
#endregion

using Foundation;
using SupportLifecycle.Services;
using UIKit;

namespace SupportLifecycle.iOS.Services
{
    /// <summary>
    ///     Web ブラウザを開くサービス
    /// </summary>
    public class OpenBrowserService : IOpenBrowserService
    {
        /// <summary>
        ///     Web ブラウザを開く
        /// </summary>
        /// <param name="uri">Uri</param>
        public void OpenUri(string uri)
        {
            SimpleLogger.WriteLine(string.Format("open to {0}", uri));

            UIApplication.SharedApplication.OpenUrl(new NSUrl(uri));
        }
    }
}