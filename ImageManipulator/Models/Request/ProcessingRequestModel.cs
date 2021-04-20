using System.Collections.Generic;

namespace ImageManipulator.Models.Request
{
    public class ProcessingRequestModel
    {
        /// <summary>
        /// Image base 64, or path
        /// </summary>
        public string ImageString { get; set; }

        /// <summary>
        /// Filters which contain filter name
        /// and value to be applied
        /// </summary>
        public IDictionary<string, string> Filters { get; set; }
    }
}
