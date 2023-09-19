using getData;

namespace WpfApp1
{
    public class DataProcessor
    {
        private readonly getjsData1 jsData;

        public DataProcessor(getjsData1 jsData) 
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