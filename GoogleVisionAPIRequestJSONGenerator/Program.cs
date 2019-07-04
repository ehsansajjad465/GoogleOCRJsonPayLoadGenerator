using Newtonsoft.Json;
using PortableClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleVisionAPIRequestJSONGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string language = "en";
            string type = "DOCUMENT_TEXT_DETECTION";
            byte[] file = System.IO.File.ReadAllBytes("ATM.png");

            BatchAnnotateImagesRequest batchRequest = new BatchAnnotateImagesRequest();
            batchRequest.Requests = new List<AnnotateImageRequest>();
            batchRequest.Requests.Add(new AnnotateImageRequest()
            {
                Features = new List<Feature>() { new Feature() { Type = type, MaxResults = 1 }, },
                ImageContext = new ImageContext() { LanguageHints = new List<string>() { language } },
                Image = new Image() { Content = Convert.ToBase64String(file) }
            });
            var temp = JsonConvert.SerializeObject(batchRequest);
        }
    }
}
