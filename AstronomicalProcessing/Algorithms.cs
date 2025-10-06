// Raphael Fernandes, Team Koi, Sprint 1
// Date: 22/09/2025
// Version: 1.0
// Name: Astronomical Processing
// Class containing Sorting/Searching algorithms.
// Can handle both ascending and descending sorts.
namespace AT2_30099423
{
    /// <summary>
    /// Binary Search and Bubble search algorithms for integer lists.
    /// </summary>
    public static class Algorithms
    {
        /// <summary>
        /// Sort integer list in place using bubble sort algorithm
        /// </summary>
        /// <param name="list">list to sort</param>
        /// <param name="asc">Whether to sort ascending or descending</param>
        public static void BubbleSort(List<int> list, bool asc = true)
        {
            int max = list.Count;
            int temp;
            for (int end = max; end > 0; end--)
            {
                for (int i = 0, j = 1; j < max; i++, j++)
                {
                    if (asc ? list[i] > list[j] : list[i] < list[j])
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Uses Binary Search to find an integer in a list and return its index
        /// </summary>
        /// <param name="list">integer list to search</param>
        /// <param name="search">integer to search for</param>
        /// <param name="asc">whether the list should be sorted ascending (true) or descending (false)</param>
        /// <returns>index of search item, or -1 if the item cannot be found</returns>
        public static int BinarySearch(List<int> list, int search, bool asc = true)
        {
            int start = 0;
            int end = list.Count - 1;
            int middle;
            while (start <= end)
            {
                middle = (start + end) / 2;
                if (search == list[middle])
                    return middle;
                else if ((search < list[middle]) == asc)
                    end = middle - 1;
                else
                    start = middle + 1;

            }
            return -1;
        }
    }
}
