using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFLogicaPrimerServicio
{
    internal class MetodosVariosClass : IMetodosVariosContract
    {
        public int GetNumeroDoble(int numero)
        {
            return numero * 2;
        }

        public string GetSaludo(string nombre)
        {
            return "Mi primer WCF, bienvenido " + nombre;
        }

        public string MetodoInvisible()
        {
            return "nada que haer :(";
        }
    }
}
