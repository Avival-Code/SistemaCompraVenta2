using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SistemaCompraVenta2.ViewModels;
using SistemaCompraVenta2.Stores;

namespace SistemaCompraVenta2
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup( StartupEventArgs startupEvents )
		{
			NavigationStore navigationStore = new NavigationStore();
			navigationStore.CurrentViewModel = new PantallaPrincipalViewModel( navigationStore );
			MainWindow = new MainWindow()
			{
				DataContext = new MainViewModel( navigationStore )
			};
			MainWindow.Show();

			base.OnStartup( startupEvents );
		}
	}
}
