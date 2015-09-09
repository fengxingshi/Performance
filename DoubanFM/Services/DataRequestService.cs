using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace DoubanFM.Services
{
    public class DataRequestService<T> : IDataRequestService<T>
    {

        private HttpResponseMessage response;
        private HttpClient httpClient;

        /// <summary>
        /// 泛型通用获取接口方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url">接口url</param>
        /// <returns></returns>
        public async Task<T> GetDataAsync(string url)
        {
            httpClient = new HttpClient();
            
            var headers = httpClient.DefaultRequestHeaders;//获取每个请求标头的集合
            headers.UserAgent.ParseAdd("ie");
            headers.UserAgent.ParseAdd("Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)");

            response = new HttpResponseMessage();
            try
            {
                //httpClient.Timeout = TimeSpan.FromMilliseconds(5000);
                response = await httpClient.GetAsync(new Uri(url));
                response.EnsureSuccessStatusCode();
                string responseText = await response.Content.ReadAsStringAsync();
                
                return JsonConvert.DeserializeObject<T>(responseText);

            }
            catch (Exception ex)
            {
                return default(T);
            }
        }
    }
}
