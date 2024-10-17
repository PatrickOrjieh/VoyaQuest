using VoyaQuest.Models.FlightOffersResponse;

namespace VoyaQuest.Comparators
{
    /// <summary>
    /// This class provides a comparison method for sorting FlightOffer objects based on their duration.
    /// </summary>
    public class DurationComparator: IComparer<FlightOffer>
    {
        /// <summary>
        /// This field represents the sort order of the comparison.
        /// </summary>
        private readonly bool _ascending;

        public DurationComparator(bool ascending = true)
        {
            _ascending = ascending;
        }

        /// <summary>
        /// This method compares two FlightOffer objects based on their duration.
        /// </summary>
        /// <param name="x">The first FlightOffer object to compare.</param>
        /// <param name="y">The second FlightOffer object to compare.</param>
        /// <returns>Returns 0 if the durations are equal, -1 if x is less than y, and 1 if x is greater than y.</returns>
        public int Compare(FlightOffer x, FlightOffer y)
        {
            if (x == null || y == null)
                return 0;

            TimeSpan durationX = TimeSpan.Parse(x.itineraries.First().duration.Replace("PT", "").ToLower());
            TimeSpan durationY = TimeSpan.Parse(y.itineraries.First().duration.Replace("PT", "").ToLower());

            // If ascending is true, sort from shortest to longest
            return _ascending ? durationX.CompareTo(durationY) : durationY.CompareTo(durationX);
        }
    }
}
