using Newtonsoft.Json;
using NUnit.Framework;
using System.IO;
using System.Net;

namespace SecondFormTest
{
    public class ApiTests
    {
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMethod1()
        {
            string url = "https://tarasmysko89.wixsite.com/vectortesttask01";
            string html;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
            Stream stream = response.GetResponseStream();
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            //var resp = JsonConvert.DeserializeObject<SingleUserResponseObject>(html);
            //Assert.IsTrue(resp.data.id.Equals(2));
        }

        [Test]
        public void TestMethod2()
        {
            string html;

            //var reqObject = new UsersRequestObject();
            //reqObject.name = "morpheus";
            //reqObject.email = "leader";

            // string request = JsonConvert.SerializeObject(reqObject);
            string url = "https://tarasmysko89.wixsite.com/vectortesttask01/api/join";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";
            /*
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(request);
            }
            */
            HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
            Stream stream = response.GetResponseStream();
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            /*
            var apiResponse = JsonConvert.DeserializeObject<UsersResponseObject>(html);
            Assert.IsTrue(apiResponse.name.Equals("morpheus") && apiResponse.job.Equals("leader"));
            */
        }

    }
}