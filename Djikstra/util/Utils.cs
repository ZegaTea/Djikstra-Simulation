using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djikstra.util
{
	class Utils
	{
		public static int getMaxLine(int n)
		{
			if (n == 1) return 1;
			else
			{
				return (n + n * (n - 3) / 2);
			}
		}
	}
}
