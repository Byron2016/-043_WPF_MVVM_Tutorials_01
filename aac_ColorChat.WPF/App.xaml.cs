using aac_ColorChat.WPF.Services;
using aac_ColorChat.WPF.ViewModels;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace aac_ColorChat.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // El URL de conexión sale de ir al proyecto servidor, Properties/launchSettings.json
            // sección profiles/aac_ColorChat.SignalR
            // agregado el endPoint

            HubConnection connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5010/colorchat")
                .Build();

            ColorChatViewModel chatViewModel =  ColorChatViewModel.CreatedConnectedViewModel(new SignalRChatService(connection));

            MainWindow window = new MainWindow
            {
                DataContext = new MainViewModel(chatViewModel)
            };

            window.Show();
        }
    }
}
