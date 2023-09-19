using System;
using System.Collections.Generic;
using System.Net.Http;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace getData
{
    public class JsData
    {
        private readonly string apiUrl;

        public JsData(string apiUrl)
        {
            this.apiUrl = apiUrl;
        }

        public (List<double> labels, List<double> values) GetData()
        {
            using (var driver = new ChromeDriver())
            {
                try
                {
                    using (var httpClient = new HttpClient())
                    {
                        // Fetch data from the API
                        var apiResponse = httpClient.GetStringAsync(apiUrl).Result;

                        // Navigate to the URL in a web driver
                        driver.Navigate().GoToUrl(apiUrl);

                        // Execute JavaScript to get labels and values
                        var labelsob = ((IJavaScriptExecutor)driver).ExecuteScript("return labels");
                        var valuesob = ((IJavaScriptExecutor)driver).ExecuteScript("return values");

                        return ((List<double>)labelsob, (List<double>)valuesob);
                    }
                }
                catch (Exception ex)
                {
                    // Handle and log exceptions appropriately
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    throw; // Rethrow the exception for further handling if needed
                }
            }
        }
    }
}
