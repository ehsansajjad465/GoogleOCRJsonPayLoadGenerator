using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableClassLibrary
{
    public class LatLongRect
    {
        /// <summary>Max lat/long pair.</summary>
        [JsonProperty("maxLatLng")]
        public virtual LatLng MaxLatLng
        {
            get;
            set;
        }

        /// <summary>Min lat/long pair.</summary>
        [JsonProperty("minLatLng")]
        public virtual LatLng MinLatLng
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
