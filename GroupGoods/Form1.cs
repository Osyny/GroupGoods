using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupGoods
{
    public partial class Form1 : Form
    {

        public Logic logic = Logic.getInstance();
       // List<ShipmentData> tmpGoods = new List<ShipmentData>();
        public Form1()
        {
            InitializeComponent();

            updateGoods();
        }

        public void updateGoods()
        {
            var goods = logic.GetGoods();
            dataGridViewGoods.Rows.Clear();
            foreach (var good in goods)
            {
                var index = dataGridViewGoods.Rows.Add(good.date);

                dataGridViewGoods.Rows[index].Cells[1].Value = good.countryName;
                dataGridViewGoods.Rows[index].Cells[2].Value = good.cityName;
                dataGridViewGoods.Rows[index].Cells[3].Value = good.managerName;
                dataGridViewGoods.Rows[index].Cells[4].Value = good.qty;
                dataGridViewGoods.Rows[index].Cells[5].Value = good.price;

                dataGridViewGoods.Rows[index].Tag = good.id;
            }
        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {

        }
    }
}
