using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanCloseLibMvvm
{
	/// <summary>
	/// this interface defines how to call to check whether closing the window is ok
	/// or not.
	/// </summary>
	public interface ICanCloseCheck
	{
		void CheckCanClose(ICanCloseResult canCloseResult);
	}
}
