using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ServerLogic
    {
        GoodsEntities db;
        public ServerLogic()
        {
            db = new GoodsEntities();
        }

        public List<ShipmentGoods> GetGoods()
        {
            var goods = db.ShipmentGoods.Select(g => g).ToList();

            return goods;
        }
    }
}
