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
    public partial class ChartPassabilityForm : Form
    {
        public ChartPassabilityForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void ChartPassabilityForm_Load(object sender, EventArgs e)
        {
            string[] seriesArray = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь","Июль","Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};
            int[] pointsArray = { 14000, 80000, 70000, 93000, 40000,0,0,0,0,0,0,0};
            this.chart1.Palette = ChartColorPalette.SeaGreen;
            this.chart1.Titles.Add("График прибыли продаж");
           
            for (int i = 0; i < seriesArray.Length; i++)
            {
               Series series = this.chart1.Series.Add(seriesArray[i]);
               series.Points.Add(pointsArray[i]);
            }
            //chart1.SaveImage("‪kjnkn.png", ChartImageFormat.Png); //save chart on button later
        }

    }
}
