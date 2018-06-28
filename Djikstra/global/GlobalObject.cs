using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djikstra.global
{
	class GlobalObject
	{
		public static HashSet<string> setLines = new HashSet<string>();
		public static Dictionary<String, int> mapDistance = new Dictionary<string, int>();
		public static int maxScore = 20;
		public static int maxLine = 400;
		public static int MAX_VALUE = 100000;
	}
}
