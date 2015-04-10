#region License
//-----------------------------------------------------------------------
// <copyright>
//     Copyright matatabi-ux 2015.
// </copyright>
//-----------------------------------------------------------------------
#endregion

namespace SupportLifecycle.Services
{
    /// <summary>
    /// Web ブラウザを開くサービスのインタフェース
    /// </summary>
    public interface IOpenBrowserService
    {
        /// <summary>
        /// Web ブラウザを開く
        /// </summary>
        /// <param name="uri">Uri</param>
        void OpenUri(string uri);
    }
}
