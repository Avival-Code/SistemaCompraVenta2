using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SistemaCompraVenta2.Commands
{
	public abstract class CommandBase : ICommand
	{
		protected void OnCanExecuteChanged()
		{
			CanExecuteChanged?.Invoke(this, new EventArgs());
		}

		public virtual bool CanExecute( object parameter ) => true;

		public abstract void Execute( object parameter );

		public event EventHandler CanExecuteChanged;
	}
}