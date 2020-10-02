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

      
        public List<ShipmentGoods> groupData()
        {
            List<ShipmentGoods> goodsVm = new List<ShipmentGoods>();

            var res = db.ShipmentGoods.GroupBy(g => g.date).ToList();

            foreach(var group in res)
            {
                var dateVm = new ShipmentGoods()
                {
                    date = group.Key.Value,
                    qty = group.Sum(g => g.qty).Value,
                    price = group.Sum(g => g.price).Value,
                };

                goodsVm.Add(dateVm);
            }

            return goodsVm;

           
        }
    }
}
