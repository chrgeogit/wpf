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
        private double[] labels;
        private double[] values;

        public MainWindow()
        {
            InitializeComponent();
            object labelsob = new object();
            object valuesob = new object();
            var jsdata = new getjsData();
            labelsob = jsdata.labels;
            valuesob = jsdata.values;
            var x = ExtractDouble(labelsob);
          var y =   ExtractDouble(valuesob);
            plot1.Plot.AddScatter(labels,values);
            plot1.Refresh();
        }

        private double[] ExtractDouble(object? _jsob)
        {
            throw new NotImplementedException();
        }
    }
}
