using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerBIDemo.Models
{
    public class MLAPIResponse
    {
        public string AddedOn { get; set; }
        public string ConnectionID { get; set; }
        public string IP { get; set; }
        public string CartItem { get; set; }
        public string Scored_Probabilities_for_Class_Books { get; set; }	
        public string Scored_Probabilities_for_Class_Clothes { get; set; }
        public string Scored_Probabilities_for_Class_Electronics { get; set; }
        public string Scored_Probabilities_for_Class_Flowers { get; set; }
        public string Scored_Probabilities_for_Class_Food { get; set; }
        public string Scored_Probabilities_for_Class_Furniture { get; set; }
        public string Scored_Probabilities_for_Class_Perfumes { get; set; }
        public string Scored_Probabilities_for_Class_Shoes { get; set; }
        public string Scored_Probabilities_for_Class_Toys { get; set; }
        public string Scored_Probabilities_for_Class_Wines { get; set; }
        public string Scored_Labels { get; set; }

        public string Scored_Confidence {
            get
            {
                var tempConfidence = Convert.ToDecimal(Scored_Probabilities_for_Class_Books);

                if (Convert.ToDecimal(Scored_Probabilities_for_Class_Clothes) > tempConfidence)
                {
                    tempConfidence = Convert.ToDecimal(Scored_Probabilities_for_Class_Clothes);
                }
                if (Convert.ToDecimal(Scored_Probabilities_for_Class_Electronics) > tempConfidence)
                {
                    tempConfidence = Convert.ToDecimal(Scored_Probabilities_for_Class_Electronics);
                }
                if (Convert.ToDecimal(Scored_Probabilities_for_Class_Flowers) > tempConfidence)
                {
                    tempConfidence = Convert.ToDecimal(Scored_Probabilities_for_Class_Flowers);
                }
                if (Convert.ToDecimal(Scored_Probabilities_for_Class_Food) > tempConfidence)
                {
                    tempConfidence = Convert.ToDecimal(Scored_Probabilities_for_Class_Food);
                }
                if (Convert.ToDecimal(Scored_Probabilities_for_Class_Furniture) > tempConfidence)
                {
                    tempConfidence = Convert.ToDecimal(Scored_Probabilities_for_Class_Furniture);
                }
                if (Convert.ToDecimal(Scored_Probabilities_for_Class_Perfumes) > tempConfidence)
                {
                    tempConfidence = Convert.ToDecimal(Scored_Probabilities_for_Class_Perfumes);
                }
                if (Convert.ToDecimal(Scored_Probabilities_for_Class_Shoes) > tempConfidence)
                {
                    tempConfidence = Convert.ToDecimal(Scored_Probabilities_for_Class_Shoes);
                }
                if (Convert.ToDecimal(Scored_Probabilities_for_Class_Toys) > tempConfidence)
                {
                    tempConfidence = Convert.ToDecimal(Scored_Probabilities_for_Class_Toys);
                }
                if (Convert.ToDecimal(Scored_Probabilities_for_Class_Wines) > tempConfidence)
                {
                    tempConfidence = Convert.ToDecimal(Scored_Probabilities_for_Class_Wines);
                }

                return (tempConfidence * 100).ToString("0.00");
            }
        }

    }
}
