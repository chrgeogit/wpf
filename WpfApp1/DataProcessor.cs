using getData;

namespace WpfApp1
{
    public class DataProcessor
    {
        private readonly getjsData jsData;

        public DataProcessor(getjsData jsData) 
        {
            this.jsData = jsData;
        }
        public (double[] labels, double[] values) GetProcessedData() 
        {
            try
            {
                var labels = jsData.GetLabels();
                var values = jsData.GetValues();

                return (labels, values);

            }
            catch
            {
                return (null, null);
            }
        
        }
    }
}