#region License
//-----------------------------------------------------------------------
// <copyright>
//     Copyright matatabi-ux 2015.
// </copyright>
//-----------------------------------------------------------------------
#endregion

using System;
using Xamarin.Forms;

namespace SupportLifecycle.Services
{
    /// <summary>
    ///     Web �u���E�U���J���T�[�r�X
    /// </summary>
    public class OpenBrowserService : IOpenBrowserService
    {
        /// <summary>
        ///     Web �u���E�U���J��
        /// </summary>
        /// <param name="uri">Uri</param>
        public void OpenUri(string uri)
        {
            SimpleLogger.WriteLine(string.Format("open to {0}", uri));

            Device.OpenUri(new Uri(uri, UriKind.Absolute));
        }
    }
}