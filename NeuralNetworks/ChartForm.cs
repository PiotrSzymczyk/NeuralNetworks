using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts.WinForms;

namespace NeuralNetworks
{
    public class ChartForm : Form, ICustomLogger
    {
        private LiveCharts.WinForms.CartesianChart cartesianChart1;

        public ChartForm()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {

                new ScatterSeries
                {
                    Title = "Errors",
                    Values = new ChartValues<ObservablePoint>(),
                    PointGeometry = DefaultGeometries.Triangle
                },
                new ScatterSeries
                {
                    Title = "Positives",
                    Values = new ChartValues<ObservablePoint>(),
                    PointGeometry = DefaultGeometries.Diamond
                },
                new ScatterSeries
                {
                    Title = "Negatives",
                    Values = new ChartValues<ObservablePoint>(),
                    PointGeometry = DefaultGeometries.Circle
                }
            };


            cartesianChart1.Series = SeriesCollection;
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
        }

        public SeriesCollection SeriesCollection { get; set; }

        private void InitializeComponent()
        {
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(12, 12);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(848, 700);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // ChartForm
            // 
            this.ClientSize = new System.Drawing.Size(871, 727);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "ChartForm";
            this.Load += new System.EventHandler(this.ChartForm_Load);
            this.ResumeLayout(false);

        }

        private void ChartForm_Load(object sender, EventArgs e)
        {

        }

        public void Log(DataSetRecord record)
        {
            if (record.ExpectedOutput != record.ActualOutput)
            {
                SeriesCollection[0].Values.Add(new ObservablePoint(record.Inputs[0], record.Inputs[1]));
            }
            else if (record.ActualOutput == 1)
            {
                SeriesCollection[1].Values.Add(new ObservablePoint(record.Inputs[0], record.Inputs[1]));
            }
            else
            {
                SeriesCollection[2].Values.Add(new ObservablePoint(record.Inputs[0], record.Inputs[1]));
            }
            this.cartesianChart1.Update();
        }
    }
}
