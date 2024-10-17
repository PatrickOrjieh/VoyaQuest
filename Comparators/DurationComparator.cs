using System.Text.RegularExpressions;
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
            TimeSpan durationX = ParseDuration(x.itineraries?.FirstOrDefault()?.duration);
            TimeSpan durationY = ParseDuration(y.itineraries?.FirstOrDefault()?.duration);

            int result = durationX.CompareTo(durationY);

            return _ascending ? result : -result;
        }

        /// <summary>
        /// This method parses a duration string into a TimeSpan object.
        /// </summary>
        /// <param name="duration">The duration string to parse.</param>
        /// <returns>Returns a TimeSpan object representing the duration.</returns>
        private TimeSpan ParseDuration(string duration)
        {
            if (string.IsNullOrEmpty(duration))
            {
                return TimeSpan.Zero;
            }

            // Sample input: "1h45m" from the Amadeus API
            int hours = 0, minutes = 0;

            var match = Regex.Match(duration, @"(?:(\d+)h)?(?:(\d+)m)?");

            if (match.Success)
            {
                if (!string.IsNullOrEmpty(match.Groups[1].Value))
                {
                    hours = int.Parse(match.Groups[1].Value);
                }
                if (!string.IsNullOrEmpty(match.Groups[2].Value))
                {
                    minutes = int.Parse(match.Groups[2].Value);
                }
            }

            return new TimeSpan(hours, minutes, 0);
        }
    }
}
