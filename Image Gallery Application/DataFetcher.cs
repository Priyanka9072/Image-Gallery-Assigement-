using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static ImageGallery_Application.DataFetcher;

namespace ImageGallery_Application
{
    class DataFetcher
    {

        public bool flag = true;
        async Task<string> GetDatafromService(int count, string searchstring)
        {
            string readText = null;
            try
            {
                var azure = @"https://imagefetcher20200529182038.azurewebsites.net";
                string url = azure + @"/api/fetch_images?query=" +
               searchstring + "&max_count=" + count;
                using (HttpClient c = new HttpClient())
                {
                    readText = await c.GetStringAsync(url);
                }
            }
            catch
            {
                flag = false;
                readText = File.ReadAllText(@"Data/sampleData.json");
            }
            return readText;
        }
        public async Task<List<ImageItem>> GetImageData(string search, int count = 12)
        {
            string data = await GetDatafromService(count, search);
            return JsonConvert.DeserializeObject<List<ImageItem>>(data);
        }

        internal interface IStatus
        {
        }

      
    }
}
