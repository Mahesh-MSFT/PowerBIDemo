using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerBIDemo.Models
{
    public class OutgoingResponse
    {
        public string NewCartItem { get; set; }

        public string NextPrediction { get; set; }

        public string NextPredictionConfidence { get; set; }

        public Dictionary<string, string> CartItemsOfOthers { get; set; }
    }
}
