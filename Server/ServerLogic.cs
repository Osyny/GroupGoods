using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    enum filds
    {
        date,
        organization,
        cityName,
        managerName,
        countryName,
        qty,
        price
    }
    public class ServerLogic
    {
        GoodsEntities db;
        private SqlReqest sqlReqest;
        public ServerLogic()
        {
            db = new GoodsEntities();
            sqlReqest = new SqlReqest(db);
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

            foreach (var group in res)
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

        public List<ShipmentGoods> SelectData(Dictionary<int, string> groupFields)
        {
            List<ShipmentGoods> goodsVm = new List<ShipmentGoods>();

            if (groupFields.Count > 0)
            {
                //List<IGrouping<string, ShipmentGoods>> res = new List<IGrouping<string, ShipmentGoods>>();
                //List<IGrouping<DateTime?, ShipmentGoods>> resData = new List<IGrouping<DateTime?, ShipmentGoods>>();
                foreach (var f in groupFields)
                {
                    if (f.Key == (int)filds.date)
                    {
                        var resData = db.ShipmentGoods.GroupBy(g => g.date).ToList();
                        foreach (var groupDate in resData)
                        {
                            var dateVm = new ShipmentGoods()
                            {
                                date = groupDate.Key.Value,
                                qty = groupDate.Sum(g => g.qty).Value,
                                price = groupDate.Sum(g => g.price).Value,
                            };
                            goodsVm.Add(dateVm);
                        }

                    }

                    if (f.Key == (int)filds.organization)
                    {
                        var res1 = db.ShipmentGoods.GroupBy(g => g.organization).ToList();
                        foreach (var group in res1)
                        {
                            var groupVm = new ShipmentGoods()
                            {
                                organization = group.Key,
                                qty = group.Sum(g => g.qty).Value,
                                price = group.Sum(g => g.price).Value,
                            };
                            goodsVm.Add(groupVm);
                        }
                    }
                    if (f.Key == (int)filds.cityName)
                    {
                        var res1 = db.ShipmentGoods.GroupBy(g => g.cityName).ToList();
                        foreach (var group in res1)
                        {
                            var groupVm = new ShipmentGoods()
                            {
                                cityName = group.Key,
                                qty = group.Sum(g => g.qty).Value,
                                price = group.Sum(g => g.price).Value,
                            };
                            goodsVm.Add(groupVm);
                        }
                    }
                    if (f.Key == (int)filds.managerName)
                    {
                        var res1 = db.ShipmentGoods.GroupBy(g => g.managerName).ToList();
                        foreach (var group in res1)
                        {
                            var groupVm = new ShipmentGoods()
                            {
                                countryName = group.Key,
                                qty = group.Sum(g => g.qty).Value,
                                price = group.Sum(g => g.price).Value,
                            };
                            goodsVm.Add(groupVm);
                        }
                    }
                    if (f.Key == (int)filds.countryName)
                    {
                        var res1 = db.ShipmentGoods.GroupBy(g => g.countryName).ToList();
                        foreach (var group in res1)
                        {
                            var groupVm = new ShipmentGoods()
                            {
                                managerName = group.Key,
                                qty = group.Sum(g => g.qty).Value,
                                price = group.Sum(g => g.price).Value,
                            };
                            goodsVm.Add(groupVm);
                        }
                    }


                }

                var t = goodsVm;

            }
            else
            {
                var res = GetGoods();

                goodsVm = res;
            }

            return goodsVm;

        }

        public List<ShipmentGoods> selectData(Dictionary<int, string> groupDict, List<string> actualFields)
        {
            List<ShipmentGoods> goodsVm = new List<ShipmentGoods>();

             var groupFields = groupDict.Select(g => g.Value).ToList();

            string selectString = "Select ";
            string fromString = "FROM ShipmentGoods";
            string groupString = "";
            int i = 0;

            if (groupFields.Count > 0)
            {
                groupString += "GROUP BY ";

                for (i = 0; i < groupFields.Count - 1; i++)
                {
                    selectString += groupFields[i] + ", ";
                    groupString += groupFields[i] + ", ";
                }
                selectString += groupFields[i];
                groupString += groupFields[i];

                selectString += ", SUM(qty), SUM(price)";
            }
            else
            {
                selectString += "date, organization, cityName, countryName, managerName, qty, price";
            }
            var selectStr = selectString + " " + fromString + " " + groupString;
            var groupStr = groupString;

            goodsVm = sqlReqest.GetReq(selectStr, actualFields);

            return goodsVm;
        }


    }
}
