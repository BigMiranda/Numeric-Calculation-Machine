using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace Trabalho_do_Marcio
{
	class Funcao
	{
		public static double ResolveFuncao ( string funcao, double x )
		{
			Function f = new Function ( "f(x)=" + funcao );
			return ( f.calculate ( x ) );
		}
	}
}
