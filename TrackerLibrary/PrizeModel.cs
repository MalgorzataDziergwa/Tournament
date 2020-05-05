using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Numeric Identifier for the place ( ex. 2 for second place).
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Name for the place (ex. first runner up).
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Fix amount this place earns or a 0 if it's not used.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// The number that represents the percetage of an overall take or
        /// 0 if it's not used. The Pecentage is a fraction of 1(ex. 0.5 for 50%).
        /// </summary>
        public int PrizePercentage { get; set; }

      
    }
}
