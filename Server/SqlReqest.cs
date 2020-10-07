using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class SqlReqest
    {
        private GoodsEntities db;

        public SqlReqest(GoodsEntities db)
        {
            this.db = db;
        }
        public List<ShipmentGoods> GetReq(string selectStr, string groupStr)
        {

            var res = new List<ShipmentGoods>();

            var c1 = new CMdCommandTest().Init(this.db.Database.Connection).Open();

            c1.PerformCmd(CommonCMdFac.GetGroup(selectStr, groupStr));

            c1.GetRecords((val) => this.FillFromSql(val, res));

            c1.Close();
            return res;

        }

        private void FillFromSql(System.Data.IDataRecord val, List<ShipmentGoods> res)
        {
            if (val.IsDBNull(0))
            {
                return;
            }
           

           res.Add((ShipmentGoods)val.GetValue(0));
        }
    }
}
