using System;
using System.Collections.Generic;
using System.Text;
using SistemaCompraVenta2.ViewModels;
using SistemaCompraVenta2.Stores;

namespace SistemaCompraVenta2.Services
{
	public class NavigationService< TViewModel >
		where TViewModel : ViewModelBase
	{
		public NavigationService( NavigationStore navigationStore, Func< TViewModel > createViewModel )
		{
			_navigationStore = navigationStore;
			_createViewModel = createViewModel;
		}

		public void Navigate()
		{
			_navigationStore.CurrentViewModel = _createViewModel();
		}

		private readonly NavigationStore _navigationStore;
		private readonly Func< TViewModel > _createViewModel;
	}
}