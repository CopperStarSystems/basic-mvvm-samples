using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MvvmSamples.ViewModel;

namespace MvvmSamples
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var shell = new MainWindow();
            var viewModel = new MainViewModel();
            shell.DataContext = viewModel;
            shell.Show();
        }
    }
}
