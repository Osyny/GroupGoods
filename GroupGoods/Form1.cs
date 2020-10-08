using Server;
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
        List<ShipmentGoods>  selectGoods = new List<ShipmentGoods>();
        public Form1()
        {
            InitializeComponent();
            selectGoods = logic.GetGoods();

            updateGoods();
        }

        public void updateGoods()
        {
            

            dataGridViewGoods.Rows.Clear();
            foreach (var good in selectGoods)
            {
                var index = dataGridViewGoods.Rows.Add(good.date);

                dataGridViewGoods.Rows[index].Cells[1].Value = good.organization;
                dataGridViewGoods.Rows[index].Cells[2].Value = good.cityName;
                dataGridViewGoods.Rows[index].Cells[3].Value = good.managerName;
                dataGridViewGoods.Rows[index].Cells[4].Value = good.countryName;
                dataGridViewGoods.Rows[index].Cells[5].Value = good.qty;
                dataGridViewGoods.Rows[index].Cells[6].Value = good.price;

                dataGridViewGoods.Rows[index].Tag = good.id;
            }
        }

        //private void showAll()
        //{
        //    List<string> groupFields = new List<string>();
        //   // List<string> actualFields = new List<string>() { "Date", "Organization", "CityName", "CountryName", "ManagerName" };

        //    selectGoods = logic.selectData(groupFields/*, actualFields*/);
        //    updateGoods();
        //}

        private void showGroup()
        {
            Dictionary<int, string> groupFields = new Dictionary<int, string>();
           // List<string> actualFields = new List<string>();

            if (checkBoxDate.Checked)
            {
                groupFields.Add(0, "date");
               
            }
            if (checkBoxOrganisation.Checked)
            {
                groupFields.Add(1, "organization");
               
            }
            if (checkBoxCity.Checked)
            {
                groupFields.Add(2, "cityName");              
            }
            if (chekBoxManager.Checked)
            {
                groupFields.Add(3, "managerName");              
            }
            if (checkBoxCountry.Checked)
            {
                groupFields.Add(4, "countryName");
            }

            if (groupFields.Count == 0)
            {
                updateGoods();
                return;
            }

            selectGoods = logic.selectData(groupFields);
            updateGoods();
        }


        private void buttonGroup_Click(object sender, EventArgs e)
        {
            showGroup();
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            selectGoods = logic.GetGoods();
            updateGoods();
        }

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDate.Checked)
            {
               selectGoods = logic.groupData();
            }
            else
            {
                selectGoods = logic.GetGoods();
            }
           
            updateGoods();
        }
    }
}
