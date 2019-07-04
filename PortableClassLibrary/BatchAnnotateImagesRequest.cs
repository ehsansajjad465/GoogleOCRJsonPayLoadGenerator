using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableClassLibrary
{
    public class BatchAnnotateImagesRequest 
    {
        public BatchAnnotateImagesRequest()
        {

        }

        //
        // Summary:
        //     Individual image annotation requests for this batch.
        [JsonProperty("requests")]
        public virtual IList<AnnotateImageRequest> Requests { get; set; }
        //
        // Summary:
        //     The ETag of the item.
        public virtual string ETag { get; set; }
    }
}
