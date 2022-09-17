namespace QuickAndExternalSorting
{
    public static class QuickSort
    {
        public static void QuickSorting(int[] array)
        {
            Sorting(0, array.Length - 1);

            void Sorting(int L, int R)
            {
                if (L >= R)
                {
                    return;
                }
                int M = Split(L, R);
                Sorting(L, M - 1);
                Sorting(M + 1, R);

            }

            int Split(int L, int R)
            {
                int P = array[R];
                int M = L - 1;
                for (int j = L; j <= R; j++)
                {
                    if (array[j] <= P)
                    {
                        Swap(++M, j);
                    }
                }
                return M;
            }

            void Swap(int L, int R)
            {
                var swap = array[R];
                array[R] = array[L];
                array[L] = swap;
            }
        }
    }
}
