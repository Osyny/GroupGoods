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
        public List<ShipmentGoods> GetReq(string selectStr, List<string> actualFields)
        {

            var res = new List<ShipmentGoods>();

            var c1 = new CMdCommandTest().Init(this.db.Database.Connection).Open();

            c1.PerformCmd(CommonCMdFac.GetGroup(selectStr));

            //   c1.GetRecords((val) => this.FillFromSql(val, res));
            c1.GetRecords_1();
          
            c1.Close();
            return res;

        }

        private void FillFromSql(System.Data.IDataRecord val, List<ShipmentGoods> res1)
        {
            if (val.IsDBNull(0))
            {
                return;
            }
            List<List<string>> res = new List<List<string>>();

           // var t = val.GetValue();
        }
    }
}
