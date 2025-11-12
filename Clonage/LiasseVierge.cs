using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clonage
{
    public class LiasseVierge:Liasse
    {
        private static LiasseVierge _instance;

        public static LiasseVierge Instance()
        {
            if (_instance == null)
            {
                _instance = new LiasseVierge();
            }
            return _instance;

        }
        public void rajouter()
        {

        }
        public void retire()
        {

        }
    }
}
