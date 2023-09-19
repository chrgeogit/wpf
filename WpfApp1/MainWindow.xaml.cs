using getData;
using System;
using System.Windows;
using ScottPlot;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private readonly JsData? jsdata;

        public MainWindow()
        {
            InitializeComponent();
            this.jsdata = ((App)Application.Current).Jsdatainst;
            InitializePlot();
        }

        private void InitializePlot()
        {
            try
            {
                var (labels, values) = jsdata.GetData();
              double[]   labelsarr = labels.ToArray();
              double[]   valuesarr = values.ToArray();

                if (labels != null && values != null)
                {
                    plot1.Plot.AddScatter(labelsarr, valuesarr);
                    plot1.Refresh();
                }
                else
                {
                    MessageBox.Show("Data is missing or invalid.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
