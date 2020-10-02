using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ViewModel
    {
    }

    public class GoodsVm
    {
        public string Date { get; set; } = "-";
        public int Qty { get; set; } = 0;
        public decimal Price { get; set; } = 0;
    }
}
