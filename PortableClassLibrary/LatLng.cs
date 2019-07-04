using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableClassLibrary
{
    public class LatLng
    {
        /// <summary>The latitude in degrees. It must be in the range [-90.0, +90.0].</summary>
        [JsonProperty("latitude")]
        public virtual double? Latitude
        {
            get;
            set;
        }

        /// <summary>The longitude in degrees. It must be in the range [-180.0, +180.0].</summary>
        [JsonProperty("longitude")]
        public virtual double? Longitude
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
