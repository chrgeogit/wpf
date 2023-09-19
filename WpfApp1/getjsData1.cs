using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Runtime.CompilerServices;
    using System.Security.AccessControl;

    namespace getData
    {
        public class getjsData
        {
            public string urlp = "http://192.168.2.15:5000/api/power";
            private string result = "";
            private HttpClient? client;
            private IWebDriver? _driver;
            private IJavaScriptExecutor? _js;
            public string webpageResult
            {
                get { return result; }
                set { result = value; }
            }
            public IJavaScriptExecutor js
            {
                get { return _js; }
                set { _js = value; }
            }
            public IWebDriver driver
            {
                get { return _driver; }
                set { _driver = value; }
            }
            public object? labels;
            public object? values;

            public getjsData()
            {
                client = new HttpClient();
                driver = new ChromeDriver();
                var webpageResult = client.GetStringAsync(urlp);
                driver.Navigate().GoToUrl(urlp);
                labels = js.ExecuteAsyncScript("labels");
                values = js.ExecuteAsyncScript("values");
                driver.Quit();


            }










        }
    }
}
