using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableClassLibrary
{
    /// <summary>Client image to perform Google Cloud Vision API tasks over.</summary>
    public class Image
    {
        /// <summary>Image content, represented as a stream of bytes.</summary>
        [JsonProperty("content")]
        public virtual string Content
        {
            get;
            set;
        }

        /// <summary>Google Cloud Storage image location. If both 'content' and 'source' are filled for an image,
        /// 'content' takes precedence and it will be used for performing the image annotation request.</summary>
        [JsonProperty("source")]
        public virtual ImageSource Source
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
