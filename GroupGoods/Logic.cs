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
        ServerLogic serverLogic;

        static private Logic instance = null;
        public static Logic getInstance()
        {
            if (instance == null)
                instance = new Logic();

            return instance;
        }

        public Logic()
        {
            serverLogic = new ServerLogic();
        }

        public List<ShipmentGoods> GetGoods()
        {
            var res = serverLogic.GetGoods();
            return res;
        }

        public List<ShipmentGoods> selectData(Dictionary<int, string> group)
        {
            var res = serverLogic.SelectData(group);
          //  var res = serverLogic.selectData(group);

            return res;
        }
        public List<ShipmentGoods> groupData()
        {
            var res = serverLogic.groupData();
            return res;
        }
    }
}
