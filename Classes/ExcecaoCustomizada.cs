using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeProduto.Classes
{
    internal class ExcecaoCustomizada : ApplicationException
    {
        public ExcecaoCustomizada(string message) : base(message)
        {

        }
    }
}
