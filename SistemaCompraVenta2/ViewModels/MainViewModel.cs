using System;
using System.Collections.Generic;
using System.Text;
using SistemaCompraVenta2.Stores;

namespace SistemaCompraVenta2.ViewModels
{
	class MainViewModel : ViewModelBase
	{
		public MainViewModel( NavigationStore navigationStore )
		{
			_navigationStore = navigationStore;
			_navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
		}

		private void OnCurrentViewModelChanged()
		{
			OnPropertyChanged( nameof( CurrentViewModel ) );
		}

		private readonly NavigationStore _navigationStore;

		public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
	}
}
