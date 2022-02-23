using Newtonsoft.Json;
using NUnit.Framework;
using System;
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
        public void TestForm2withAPI()
        {
            string testName = "morpheus";
            string testEmail = "some@email.ua";
            string html=null;
            string url = "https://tarasmysko89.wixsite.com/_api/wix-forms/v1/submit-form";
            Form2Responce apiResponse = null;

            var reqObject = Form2Request.InitialForTest();
            reqObject.Fields[0].FirstName.Value = testName;
            reqObject.Fields[1].Email.Value = testEmail;
            string request = JsonConvert.SerializeObject(reqObject);
            Console.WriteLine(request);

            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Headers.Add("Authorization:DkCJYFzVoeAvJzUPFtYnn6OqzrRC7FACt1vERHRR09w.eyJpbnN0YW5jZUlkIjoiNGEwMDU1ZjItNDIyYy00NDkxLTgxMDMtYjFiMTMzYTc5MjkxIiwiYXBwRGVmSWQiOiIxNGNlMTIxNC1iMjc4LWE3ZTQtMTM3My0wMGNlYmQxYmVmN2MiLCJtZXRhU2l0ZUlkIjoiYzFkNjdlOTAtZmE1YS00ZjZiLTkyM2EtYWM4NGQ2NjBkNThhIiwic2lnbkRhdGUiOiIyMDIyLTAyLTIzVDE3OjA3OjIyLjk4MFoiLCJkZW1vTW9kZSI6ZmFsc2UsIm9yaWdpbkluc3RhbmNlSWQiOiI5NTU3MjYxYi01N2I0LTRlMjItOTNjNy02MGIzYjZiM2U2MmUiLCJhaWQiOiI4NmZlOGE4YS00M2JhLTQ0MjUtOTA0ZC1kMDEwNDU3ZmM5OTUiLCJiaVRva2VuIjoiOGJkNjJiNjItYjg3Ni0wYmZhLTEzMzktMWQzNWU1Yzc0NzFiIiwic2l0ZU93bmVySWQiOiJjODNhMmJjMy05NjNlLTQzMmItOWM1MC1hOWM5YjhmMzFhMGQifQ");



                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(request);

                }

                HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream stream = response.GetResponseStream();
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }

                apiResponse = JsonConvert.DeserializeObject<Form2Responce>(html);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
 
            if (html!=null) Console.WriteLine(apiResponse.SubmissionId);
            Assert.IsTrue(apiResponse != null);
            Assert.IsTrue(html != null);
            Assert.IsTrue(html.Contains(apiResponse.SubmissionId.ToString()));

        }

    }


}