using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba4_PF
{
	public class DecisionNode
	{
		public string Question { get; set; }
		public DecisionNode YesNode { get; set; }
		public DecisionNode NoNode { get; set; }
		public Disease PossibleDisease { get; set; }
	}
}
