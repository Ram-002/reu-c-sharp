using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<String, decimal> prices = new Dictionary<String, decimal>();

        private void Form1_Load(object sender, EventArgs e)
        {
            ru.cbr.www.DailyInfo dailyInfo = new ru.cbr.www.DailyInfo();
            var cursOnDate = dailyInfo.GetCursOnDate(DateTime.Today);
            var table = cursOnDate.Tables[0];

            var columns = table.Columns;
            for (int i = 0; i < columns.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine(columns[i]);
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                var row = table.Rows[i];  
                System.Diagnostics.Debug.WriteLine(row["Vname"].ToString().Trim()+"|"+
                    row["Vnom"] + "|" + 
                    row["Vcurs"] + "|" + 
                    row["Vcode"] + "|" + 
                    row["VchCode"]);

                decimal price = decimal.Parse(row["Vcurs"].ToString()) / decimal.Parse(row["Vnom"].ToString());
                String name = row["VchCode"].ToString();

                prices.Add(name, price);
                listBox1.Items.Add(name);
                listBox2.Items.Add(name);
            }

            prices.Add("RUB", 1);
            listBox1.Items.Add("RUB");
            listBox2.Items.Add("RUB");

            listBox1.Sorted = true;
            listBox2.Sorted = true;

            listBox1.SelectedItem = "USD";
            listBox2.SelectedItem = "RUB";

            System.Diagnostics.Debug.WriteLine(cursOnDate);
        }

        private void update()
        {
            if (listBox1.SelectedItem == null|| listBox2.SelectedItem == null)
            {
                return;
            }
             String from = listBox1.SelectedItem.ToString();
            String to = listBox2.SelectedItem.ToString();
            decimal value= numericUpDown1.Value;

            if (!from.Equals("RUB"))
            {
                value *= prices[from];
            }

            value /= prices[to];

            label1.Text = value.ToString("0.##");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            update();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
