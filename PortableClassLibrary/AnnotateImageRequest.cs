using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableClassLibrary
{
    public class AnnotateImageRequest
    {
        /// <summary>Requested features.</summary>
        [JsonProperty("features")]
        public virtual IList<Feature> Features
        {
            get;
            set;
        }

        /// <summary>The image to be processed.</summary>
        [JsonProperty("image")]
        public virtual Image Image
        {
            get;
            set;
        }

        /// <summary>Additional context that may accompany the image.</summary>
        [JsonProperty("imageContext")]
        public virtual ImageContext ImageContext
        {
            get;
            set;
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag
        {
            get;
            set;
        }
    }
}
