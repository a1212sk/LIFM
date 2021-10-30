using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIFM
{
    public partial class Form1 : Form
    {

        private PlotModel plotModel;
        private PlotModel plotModel2;
        private List<DataPoint> data = new List<DataPoint>();
        private List<DataPoint> data2 = new List<DataPoint>();

        public bool Fired = false;
        public Form1()
        {
            InitializeComponent();
            plotModel = new PlotModel { Title = "Example 1" };
            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                AbsoluteMaximum = 0.2,
                AbsoluteMinimum = -0.2,
                MaximumRange = 0.2,
                MinimumRange = -0.2,
                Maximum = 0.2,
                Minimum = -0.2,

            }) ;
            var ls = new LineSeries();
            for(int i = 0; i < 100; i++)
            {
                data.Add(new DataPoint(0, 0));
            }
            ls.ItemsSource = data;
            plotModel.Series.Add(ls);
            this.plotView1.Model = plotModel;
            plotModel.Title = "Neuron LIF 1";

            plotModel2 = new PlotModel { Title = "Example 2" };
            plotModel2.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                AbsoluteMaximum = 0.2,
                AbsoluteMinimum = -0.2,
                MaximumRange = 0.2,
                MinimumRange = -0.2,
                Maximum = 0.2,
                Minimum = -0.2,

            });
            var ls2 = new LineSeries();
            for (int i = 0; i < 100; i++)
            {
                data2.Add(new DataPoint(0, 0));
            }
            ls2.ItemsSource = data2;
            plotModel2.Series.Add(ls2);
            this.plotView2.Model = plotModel2;
            plotModel2.Title = "Neuron LIF 2";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Runner.Run(this);
            this.button1.Enabled = false;
        }

        public void AddTick(float x, float y)
        {
            data.RemoveAt(0);
            data.Add(new DataPoint(x, y));
            plotModel.InvalidatePlot(true);
        }

        public void AddTick2(float x, float y)
        {
            data2.RemoveAt(0);
            data2.Add(new DataPoint(x, y));
            plotModel2.InvalidatePlot(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fired = true;
        }
    }
}
