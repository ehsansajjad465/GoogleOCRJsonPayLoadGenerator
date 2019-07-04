using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableClassLibrary
{
    public class ImageSource
    {
        /// <summary>Google Cloud Storage image URI. It must be in the following form: `gs://bucket_name/object_name`.
        /// For more details, please see: https://cloud.google.com/storage/docs/reference-uris. NOTE: Cloud Storage
        /// object versioning is not supported!</summary>
        [JsonProperty("gcsImageUri")]
        public virtual string GcsImageUri
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
