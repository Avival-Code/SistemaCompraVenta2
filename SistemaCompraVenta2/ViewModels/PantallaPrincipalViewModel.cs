using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using SistemaCompraVenta2.Commands;
using SistemaCompraVenta2.Stores;

namespace SistemaCompraVenta2.ViewModels
{
	class PantallaPrincipalViewModel : ViewModelBase
	{
		public PantallaPrincipalViewModel( NavigationStore navigationStore )
		{
			//NavigatePantallaPrincipalCommand = new NavigateCommand< PantallaPrincipalViewModel >( navigationStore, 
				//											() => new PantallaPrincipalViewModel( navigationStore ) );
		}

		public ICommand NavigatePantallaPrincipalCommand { get; }
	}
}
