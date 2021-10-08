using Employees.Models;
using Employees.Models.Enums;
using Employees.REPOSITORY;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Controllers
{
    public class EmployeeRepository : IGenericRepository<Root>
    {
        string URL = @"https://gorest.co.in/public-api/users";
        public Task<string> GetUsers(string param)
        {
            HttpWebRequest request;
            if (param == null)
            {
                request = (HttpWebRequest)WebRequest.Create(URL);
            }
            else
            {
                request = (HttpWebRequest)WebRequest.Create(URL + "/" + param);
            }

            request.Headers.Add("Bearer", "fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56");
            Task<WebResponse> response = request.GetResponseAsync();
            Stream receiveStream = response.Result.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            Task<string> jsonString = readStream.ReadToEndAsync();
            response.Wait();
            readStream.Close();
            return jsonString;
        }



        public Task<string> PostPutUsers(MethodType methodType, Root root)
        {
            HttpWebRequest request;
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
                return streamReader.ReadToEndAsync();
            }
        }

        public Task<string> DeleteUsers(string id)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL + "/" + id);
            request.Headers.Add("Authorization", "Bearer fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56");
            request.Method = "DELETE";
            Task<WebResponse> response = request.GetResponseAsync();
            Stream receiveStream = response.Result.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            Task<string> jsonString = readStream.ReadToEndAsync();
            response.Wait();
            readStream.Close();
            return jsonString;
        }
    }
}
