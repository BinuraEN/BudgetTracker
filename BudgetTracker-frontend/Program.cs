using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletCtrl.Views;

namespace WalletCtrl
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var svcProvider = new ServiceCollection()
                                .AddHttpClient()
                                .BuildServiceProvider();

            var WChttpClientFactory = svcProvider.GetService<IHttpClientFactory>();

            var WCClient = WChttpClientFactory.CreateClient();

            if (WCClient.BaseAddress == null)
            {
                WCClient.BaseAddress = new Uri("https://walletctrl-api-gateway.azure-api.net");
            }

            WCClient.DefaultRequestHeaders.Accept.Clear();
            WCClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var WCContainer = new SimpleInjector.Container();
            WCContainer.Register<WCMainScreenForm>(Lifestyle.Singleton);
            WCContainer.Register(() => WCClient, Lifestyle.Singleton);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WCMainScreenForm(WCContainer));
        }
    }
}
