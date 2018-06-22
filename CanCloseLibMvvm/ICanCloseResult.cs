using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanCloseLibMvvm
{
	/// <summary>
	/// this interface defines the data structure that is used
	/// to hold the results of the CanClose query.
	/// </summary>
	public interface ICanCloseResult
	{
		bool Cancel { get; set; }
	}
}
