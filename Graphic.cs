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

namespace personal_note
{
    public partial class Graphic : Form
    {
        public Graphic(List<float> stars)
        {
            InitializeComponent();
            ShowLineChart(stars);
            ShowPieChart(stars);
        }

        private void ShowLineChart(List<float> stars)
        {
            // Create a new Chart
            Chart lineChart = new Chart();
            lineChart.Size = new Size(600, 400);
            lineChart.Location = new Point(10, 10);

            // Create a ChartArea
            ChartArea chartArea = new ChartArea();
            lineChart.ChartAreas.Add(chartArea);

            // Create a Series and add data points
            Series series = new Series
            {
                Name = "心情指數",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Line
            };

            // Add data points to the series
            for (int i = 1; i < stars.Count; i++)
            {
                series.Points.Add(new DataPoint(i, stars[i]));
            }

            lineChart.Series.Add(series);

            // Customize the chart (optional)
            lineChart.Legends.Add(new Legend("Legend1"));
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            series.Color = Color.Blue;

            // Add the Chart to the Form
            this.Controls.Add(lineChart);
        }

        private void ShowPieChart(List<float> stars)
        {
            // Convert stars to int
            List<int> intStars = stars.Select(s => (int)s).ToList();

            // Create a new Chart
            // Create a new Chart
            Chart pieChart = new Chart();
            pieChart.Size = new Size(600, 400);
            pieChart.Location = new Point(700, 10);

            // Create a ChartArea
            ChartArea chartArea = new ChartArea();
            pieChart.ChartAreas.Add(chartArea);

            // Create a Series and add data points
            Series series = new Series
            {
                Name = "DiaryData",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie
            };

            int[] count = new int[6];
            for (int i = 0; i < intStars.Count; i++)
            {
                count[intStars[i]]++;
            }

            // Example data points
            series.Points.Add(new DataPoint(0, count[0]) { LegendText = "zero" });
            series.Points.Add(new DataPoint(0, count[1]) { LegendText = "one" });
            series.Points.Add(new DataPoint(0, count[2]) { LegendText = "two" });
            series.Points.Add(new DataPoint(0, count[3]) { LegendText = "three" });
            series.Points.Add(new DataPoint(0, count[4]) { LegendText = "four" });
            series.Points.Add(new DataPoint(0, count[5]) { LegendText = "five" });

            // add a color/lengend to each data point
            series.Points[0].Color = Color.Gray;
            series.Points[1].Color = Color.Orange;
            series.Points[2].Color = Color.Yellow;
            series.Points[3].Color = Color.Green;
            series.Points[4].Color = Color.Blue;
            series.Points[5].Color = Color.Purple;

            // show color meaning in the legend
            pieChart.Legends.Add(new Legend("Legend1"));
            pieChart.Legends[0].Docking = Docking.Bottom;
            pieChart.Legends[0].Alignment = StringAlignment.Center;
            pieChart.Legends[0].Title = "心情指數";
            pieChart.Legends[0].TitleBackColor = Color.White;
            pieChart.Legends[0].TitleForeColor = Color.Black;



            pieChart.Series.Add(series);

            // Add the Chart to the Form
            this.Controls.Add(pieChart);
        }
    }
}
