using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanCloseLibMvvm
{
	/// <summary>
	/// generic implementation of ICanCloseCheck. Takes an action in the
	/// constructor parameter so that this class can be used across view models.
	/// </summary>
	public class CanCloseCheck : ICanCloseCheck
	{

		public Action<ICanCloseResult> CheckCanCloseAction;
		public void CheckCanClose(ICanCloseResult result)
		{
			CheckCanCloseAction?.Invoke(result);
		}

		private CanCloseCheck()
		{
		}

		public CanCloseCheck(Action<ICanCloseResult> action)
		{
			if (action == null)
				throw new ArgumentNullException("action");

			CheckCanCloseAction = action;
		}
	}
}
