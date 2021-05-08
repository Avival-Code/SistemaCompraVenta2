using System;
using System.Collections.Generic;
using System.Text;
using SistemaCompraVenta2.ViewModels;

namespace SistemaCompraVenta2.Stores
{
	public class NavigationStore
	{
		private void OnCurrentViewModelChanged()
		{
			CurrentViewModelChanged?.Invoke();
		}

		public ViewModelBase CurrentViewModel
		{
			get => _currentViewModel;
			set
			{
				_currentViewModel = value;
				OnCurrentViewModelChanged();
			}
		}

		private ViewModelBase _currentViewModel;
		public event Action CurrentViewModelChanged;

	}
}
