namespace AT2_30099423
{
    /// <summary>
    /// Binary Search and Bubble search algorithms for integer lists.
    /// </summary>
    public static class Algorithms
    {
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
        /// <param name="list"></param>
        /// 
        /// <param name="search"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public static int BinarySearch(List<int> list, int search, bool asc = true)
        {


            int start = 0, end = list.Count() - 1;
            int maxLoops = end > 0 ? (int)Math.Ceiling(Math.Log2(list.Count())) : 0;
            for (int i = 0; i < maxLoops; i++)
            {
                int middle = (start + end) / 2;
                if (asc ? list[middle] > search : list[middle] < search)
                {
                    end = middle + 1;
                }
                else if (asc ? list[middle] < search : list[middle] > search)
                {
                    start = middle - 1;
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }
    }
}
