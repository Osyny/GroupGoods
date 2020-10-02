using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGoods
{
    public class Logic
    {
        ServerLogic serverLogoc;

        static private Logic instance = null;
        public static Logic getInstance()
        {
            if (instance == null)
                instance = new Logic();

            return instance;
        }

        public Logic()
        {
            serverLogoc = new ServerLogic();
        }

        public List<ShipmentGoods> GetGoods()
        {
            var res = serverLogoc.GetGoods();
            return res;
        }
    }
}
