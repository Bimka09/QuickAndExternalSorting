namespace QuickAndExternalSorting
{
    public static class MergeSort
    {
        public static void MergeSorting(int[] array)
        {
            Sorting(0, array.Length - 1);

            void Sorting(int L, int R)
            {
                if (L >= R)
                {
                    return;
                }
                int M = (L + R) / 2;
                Sorting(L, M);
                Sorting(M + 1, R);
                Merge(L, M, R);

            }
            void Merge(int L, int X, int R)
            {
                int[] M = new int[R - L + 1];
                int a = L;
                int b = X + 1;
                int m = 0;
                while(a <= X && b <= R)
                {
                    if(array[a] < array[b])
                    {
                        M[m++] = array[a++];
                    }
                    else
                    {
                        M[m++] = array[b++];
                    }
                }
                while(a <= X)
                {
                    M[m++] = array[a++];
                }
                while(b <= R)
                {
                    M[m++] = array[b++];
                }
                for(int i = L; i <= R; i++)
                {
                    array[i] = M[i - L];
                }

            }
        }
    }
}
