using System;
using System.Collections.Generic;
using System.Text;
using SistemaCompraVenta2.ViewModels;
using SistemaCompraVenta2.Services;

namespace SistemaCompraVenta2.Commands
{
	public class NavigateCommand< TViewModel > : CommandBase
		where TViewModel : ViewModelBase
	{
		public NavigateCommand( NavigationService< TViewModel > navigationService )
		{
			_navigationService = navigationService;
		}

		public override void Execute( object parameter )
		{
			_navigationService.Navigate();
		}

		private readonly NavigationService< TViewModel > _navigationService;
	}
}