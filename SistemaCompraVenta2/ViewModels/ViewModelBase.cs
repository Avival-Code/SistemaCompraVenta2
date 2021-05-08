using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SistemaCompraVenta2.ViewModels
{
	public class ViewModelBase : INotifyPropertyChanged, IDisposable
	{
		protected void OnPropertyChanged( string propertyName = null )
		{
			PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
		}

		public virtual void Dispose() { }

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
