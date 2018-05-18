using System.Collections.Generic;

namespace FixedArraySample
{
	public class MainPageModel
	{
		public List<bool> Days { get; set; } = new List<bool>
		{
			false,
			false,
			true,
			false,
			false,
			false,
			true
		};
	}
}