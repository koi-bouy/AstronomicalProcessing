// Raphael Fernandes, 30099423, Sprint 2
// Date: 20/10/2025
// Version: 2.1
// Name: Astronomical Processing
// Class containing Methods for calculating Statistical Measures

namespace AstronomicalProcessing
{
    /// <summary>
    /// Class contatining methods for calculating statistical measures for an integer list
    /// </summary>
    /// <param name="list">list to calculate for</param>
    internal class Calculations(List<int> list)
    {
        private readonly List<int> _list = list;

        /// <summary>
        /// Finds max value in list
        /// </summary>
        /// <returns>max value in list</returns>
        public int Max()
        {
            return Max(_list);
        }

        /// <summary>
        /// Finds max value in given list
        /// </summary>
        /// <param name="list">list to find max value for</param>
        /// <returns>max value in given list</returns>
        public static int Max(List<int> list)
        {
            int max = list[0];
            foreach (int num in list)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        /// <summary>
        /// Finds Min value in list
        /// </summary>
        /// <returns>min value in list</returns>
        public int Min()
        {
            int min = _list[0];
            foreach (int num in _list)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }

        /// <summary>
        /// Caculates average value of list
        /// </summary>
        /// <returns>calculated average for list</returns>
        public float Average()
        {
            return Average(_list);
        }


        /// <summary>
        /// Caculates average value of given list
        /// </summary>
        /// <param name="list">list to calculate average for</param>
        /// <returns>calculated average for list</returns>
        public static float Average(List<int> list)
        {
            int sum = 0;
            foreach (int num in list)
                sum += num;
            return (float)sum / list.Count;
        }

        /// <summary>
        /// Calculates mid extreme ((min+max)/2) for list
        /// </summary>
        /// <returns>mid extreme of list</returns>
        public float MidExtreme()
        {
            List<int> extremes = [Min(), Max()];
            return Average(extremes);
        }

        /// <summary>
        /// Finds mode of list
        /// </summary>
        /// <returns>most frequent numbers in the list with the frequency at which they appear</returns>
        public (int[] Modes, int Freq) Mode()
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            // Count each item in the list
            foreach (int num in _list)
            {
                if (!counts.ContainsKey(num))
                {
                    counts[num] = 1;
                    continue;
                }
                counts[num] += 1;
            }

            List<int> nums = counts.Keys.ToList();
            List<int> freqs = counts.Values.ToList();
            int maxFreq = Max(freqs);

            // Find indices of numbers with highest frequency
            List<int> maxIndices = Algorithms.SequentialSearchAll(freqs, maxFreq);

            // Return corresponding numbers, as well as the frequency
            return (maxIndices.Select(index => nums[index]).ToArray(), maxFreq);

        }


        /// <summary>
        /// Calculates statistical range for list
        /// </summary>
        /// <returns>statistical range of list</returns>
        public int Range()
        {
            return Max() - Min();
        }


    }
}
