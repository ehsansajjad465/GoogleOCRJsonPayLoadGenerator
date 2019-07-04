using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableClassLibrary
{
    //
    // Summary:
    //     The Feature indicates what type of image detection task to perform. Users describe
    //     the type of Google Cloud Vision API tasks to perform over images by using Features.
    //     Features encode the Cloud Vision API vertical to operate on and the number of
    //     top-scoring results to return.
    public class Feature
    {
        public Feature()
        {

        }

        //
        // Summary:
        //     Maximum number of results of this type.
        [JsonProperty("maxResults")]
        public virtual int? MaxResults { get; set; }
        //
        // Summary:
        //     The feature type.
        [JsonProperty("type")]
        public virtual string Type { get; set; }
        //
        // Summary:
        //     The ETag of the item.
        public virtual string ETag { get; set; }
    }
}
