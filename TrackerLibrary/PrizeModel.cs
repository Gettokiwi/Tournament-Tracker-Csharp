using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Prize for the given place.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique id for the prize.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Numeric identifier for the place.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Name for the place.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// The amount this palce earns or zero if it's not used.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// The percentages of the overall take or zero if not used.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber,string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageAmount = 0;
            double.TryParse(prizePercentage, out prizePercentageAmount);
            PrizePercentage = prizePercentageAmount;


        }

    }
}
