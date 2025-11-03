using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyclomatic
{
    public abstract class FabriqueVehicule 
    {
         abstract public Automobile CreerAutomobile(string arg0, string arg1, int  arg2, int arg3 , int arg4);
        abstract public void CreerScooter();

    }
}
