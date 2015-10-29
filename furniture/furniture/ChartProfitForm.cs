using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace furniture
{
    public partial class ChartProfitForm : Form
    {
        public ChartProfitForm()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(640,480);
       

        }

        private void ChartProfitForm_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            String[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            chart1.ChartAreas.Add("area");
            chart1.ChartAreas["area"].AxisX.Minimum = 1;
            chart1.ChartAreas["area"].AxisX.Maximum = 12;
            chart1.ChartAreas["area"].AxisX.Interval = 1;
            chart1.ChartAreas["area"].AxisY.Minimum = 0;
            chart1.ChartAreas["area"].AxisY.Maximum = 10000;
            chart1.ChartAreas["area"].AxisY.Interval = 500;
            chart1.ChartAreas["area"].AxisY.Title = "Руб";
            chart1.ChartAreas["area"].AxisX.Title = "Мес";
            chart1.Series.Add("Visitors");
            chart1.Series["Visitors"].Color = Color.GreenYellow;
            chart1.Series["Visitors"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series.Add("Money");
            chart1.Series["Money"].Color = Color.Red;
            chart1.Series["Money"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            

            int point;
            for (point = 1; point < 13; point++)
            {
                chart1.Series["Money"].Points.AddXY(months[point - 1], 10000 / random.Next(1, 12));

            }

            for (point = 1; point < 13; point++)
            {
                chart1.Series["Visitors"].Points.AddXY(months[point - 1], 1000 / random.Next(1, 12));
               
            }

         



            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                chart1.SaveImage("‪kjnkn.png", ChartImageFormat.Png);
                MessageBox.Show("График сохранён!");
                }
            catch
            {
                MessageBox.Show("График не удалось сохранить!");
            }
           
        }


      
       
       

     
       

       
    }
}
