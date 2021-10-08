using Employees.Models;
using Employees.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Controllers
{
    public class UsersOperation
    {
        string URL = @"https://gorest.co.in/public-api/users";
        
        public List<Datum> GetUsers(string param)
        {
            HttpWebRequest request = null;
            if (param == null)
            {
                request = (HttpWebRequest)WebRequest.Create(URL );
            }
            else
            {
                request = (HttpWebRequest)WebRequest.Create(URL +"/"+ param);
            }
            
            request.Headers.Add("Bearer", "fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56");                       
            Task<WebResponse> response = request.GetResponseAsync();                       
            Stream receiveStream = response.Result.GetResponseStream();            
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            Task<string> jsonString = readStream.ReadToEndAsync();
            Root root = JsonConvert.DeserializeObject<Root>(jsonString.Result);

            response.Wait();            
            readStream.Close();
            return root.data;
        }
        
        public SetRoot PostUsers(MethodType methodType,  Root root)
        {
            SetRoot setRoot = null;
            HttpWebRequest request = null;
            if (methodType == MethodType.POST)
                request = (HttpWebRequest)WebRequest.Create(URL);
            else
                request = (HttpWebRequest)WebRequest.Create(URL + "/" + root.data[0].id.ToString());
            request.Headers.Add("Authorization", "Bearer fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56");
            request.Method = methodType.ToString();
            request.ContentType = "application/json";

            string datum = JsonConvert.SerializeObject(root.data).Replace("[", string.Empty).Replace("]", string.Empty);

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(datum);
            }

            var httpResponse = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEndAsync();
                setRoot = JsonConvert.DeserializeObject<SetRoot>(result.Result);
            }
            return setRoot;
        }


        public SetRoot DeleteUsers(string id)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL + "/" + id);
            request.Headers.Add("Authorization", "Bearer fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56");
            request.Method = "DELETE";          

            Task<WebResponse> response = request.GetResponseAsync();
            Stream receiveStream = response.Result.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            Task<string> jsonString = readStream.ReadToEndAsync();

            SetRoot setRoot = JsonConvert.DeserializeObject<SetRoot>(jsonString.Result);
            response.Wait();
            readStream.Close();
            return setRoot;
        }        
    }
}
