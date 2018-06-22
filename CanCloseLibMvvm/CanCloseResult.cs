using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanCloseLibMvvm
{
	/// <summary>
	/// basic implementation of ICanCloseResult
	/// </summary>
	public class CanCloseResult : ICanCloseResult
	{
		public bool Cancel { get; set; }
	}
}
