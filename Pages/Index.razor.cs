using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WebExtensions.Net;
using WebExtensions.Net.Notifications;

namespace LeaFLib.BrowserExt.Pages
{
    public partial class Index
    {
        [Inject]
        public IWebExtensionsApi WebExtApi { get; set; }

        private async Task NoticeAsync()
        {
            await Task.Delay(100);

        }
    }
}
