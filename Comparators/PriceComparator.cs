using VoyaQuest.Models.FlightOffersResponse;

namespace VoyaQuest.Comparators
{
    /// <summary>
    /// This class provides a comparison method for sorting FlightOffer objects based on their price.
    /// </summary>
    public class PriceComparator: IComparer<FlightOffer>
    {
        /// <summary>
        /// This field represents the sort order of the comparison.
        /// </summary>
        private readonly bool _ascending;

        public PriceComparator(bool ascending = true)
        {
            _ascending = ascending;
        }

        /// <summary>
        /// This method compares two FlightOffer objects based on their price.
        /// </summary>
        /// <param name="x">The first FlightOffer object to compare.</param>
        /// <param name="y">The second FlightOffer object to compare.</param>
        /// <returns>Returns 0 if the prices are equal, -1 if x is less than y, and 1 if x is greater than y.</returns>
        public int Compare(FlightOffer x, FlightOffer y)
        {
            if (x == null || y == null)
                return 0;

            double priceX = double.Parse(x.price.total);
            double priceY = double.Parse(y.price.total);

            // If ascending is true, sort from lowest to highest
            return _ascending ? priceX.CompareTo(priceY) : priceY.CompareTo(priceX);
        }
    }
}
