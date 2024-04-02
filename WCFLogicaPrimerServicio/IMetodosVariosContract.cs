using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFLogicaPrimerServicio
{
    [ServiceContract]
    internal interface IMetodosVariosContract
    {
        [OperationContract]
        string GetSaludo(string nombre);

        [OperationContract]
        int GetNumeroDoble(int numero);

        string MetodoInvisible();
    }
}
