using getData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DataProcessor dataProcessor;

        public MainWindow()
        {
            InitializeComponent();
            jsdata = new getjsData1();
            InitializePlot();
        }

        private void InitializePlot()
        {
            try
            {
                var labels = jsdata.GetLabels();
                var values = jsdata.GetValues();

                if (labels != null && values != null)
                {
                    plot1.Plot.AddScatter(labels, values);
                    plot1.Refresh();
                }
                else
                {
                    MessageBox.Show("Data missin or invalid.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data missin or invalid.");

            }

        }

        private double[] ExtractDouble(object? _jsob)
        {
            throw new NotImplementedException();
        }
    }
}
