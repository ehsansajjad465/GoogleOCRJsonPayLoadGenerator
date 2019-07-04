using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableClassLibrary
{
    /// <summary>Image context.</summary>
    public class ImageContext
    {
        /// <summary>List of languages to use for TEXT_DETECTION. In most cases, an empty value will yield the best
        /// results as it will allow text detection to automatically detect the text language. For languages based on
        /// the latin alphabet a hint is not needed. In rare cases, when the language of the text in the image is known
        /// in advance, setting this hint will help get better results (although it will hurt a great deal if the hint
        /// is wrong). Text detection will return an error if one or more of the languages specified here are not
        /// supported. The exact list of supported languages are specified here:
        /// https://cloud.google.com/translate/v2/using_rest#language-params</summary>
        [JsonProperty("languageHints")]
        public virtual IList<string> LanguageHints
        {
            get;
            set;
        }

        /// <summary>Lat/long rectangle that specifies the location of the image.</summary>
        [JsonProperty("latLongRect")]
        public virtual LatLongRect LatLongRect
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
