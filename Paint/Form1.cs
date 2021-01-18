using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int rows = dataGrid.RowCount;

            float sum = 0;

            for (int r = 0; r < rows; r++)
            {
                var value = dataGrid.Rows[r].Cells[0].Value;
                if (value != null)
                {
                    sum += float.Parse(value.ToString());
                }
            }

            Debug.WriteLine(sum);

            float now = 0;

            for (int r = 0; r < rows; r++)
            {
                var value = dataGrid.Rows[r].Cells[0].Value;
                if (value != null)
                {
                    var random = new Random();
                    var color = Color.FromArgb(
                        random.Next(256),
                        random.Next(256),
                        random.Next(256)
                    );


                    float angle = float.Parse(value.ToString()) / sum * 360;

                    // float avg = now + angle / 2;
                    // float x = 400 + 15 * MathF.Cos(avg / 360 * MathF.PI * 2);
                    // float y = 100 + 15 * MathF.Sin(avg / 360 * MathF.PI * 2);

                    // e.Graphics.FillPie(new SolidBrush(color), x, y, 300, 300, now, angle);
                    e.Graphics.FillPie(new SolidBrush(color), 400, 100, 300, 300, now, angle);


                    now += angle;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Debug.WriteLine("refresh");
        }

        private void dataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.Refresh();
            Debug.WriteLine("refresh cell value changed");
        }
    }
}