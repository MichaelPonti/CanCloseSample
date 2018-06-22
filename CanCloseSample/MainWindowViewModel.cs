using CanCloseLibMvvm;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanCloseSample
{
	public class MainWindowViewModel : BindableBase
	{
		public MainWindowViewModel()
		{
		}


		private bool _enableCanClose = false;
		public bool EnableCanClose
		{
			get => _enableCanClose;
			set => SetProperty<bool>(ref _enableCanClose, value);
		}


		private bool _cancelClose = false;
		public bool CancelClose
		{
			get => _cancelClose;
			set => SetProperty<bool>(ref _cancelClose, value);
		}


		private CanCloseCheck _canCloseCheck = null;
		public CanCloseCheck CanCloseCheck
		{
			get
			{
				return _canCloseCheck ??
					(_canCloseCheck = new CanCloseCheck(result => result.Cancel = CancelClose));
			}
		}

		private CanCloseResult _canCloseResult = null;
		public CanCloseResult CanCloseResult
		{
			get => _canCloseResult;
			set => SetProperty<CanCloseResult>(ref _canCloseResult, value);
		}


		private CanCloseResult _canCloseCheckParameter = new CanCloseResult { Cancel = false };
		public CanCloseResult CanCloseCheckParameter
		{
			get => _canCloseCheckParameter;
			set => SetProperty<CanCloseResult>(ref _canCloseCheckParameter, value);
		}
	}
}
