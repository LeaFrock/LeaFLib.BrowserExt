using System.Threading.Tasks;
using Blazor.BrowserExtension;

namespace LeaFLib.BrowserExt
{
    public partial class BackgroundWorker : BackgroundWorkerBase
    {
        [BackgroundWorkerMain]
        public override void Main()
        {
#pragma warning disable CA2012 // 正确使用 ValueTask
            WebExtensions.Runtime.OnInstalled.AddListener(OnInstalled);
#pragma warning restore CA2012 // 正确使用 ValueTask
        }

        private async Task OnInstalled()
        {
            var indexPageUrl = await WebExtensions.Runtime.GetURL("index.html");
            await WebExtensions.Tabs.Create(new()
            {
                Url = indexPageUrl
            });
        }
    }
}
