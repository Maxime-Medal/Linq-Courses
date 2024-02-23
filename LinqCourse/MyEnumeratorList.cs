using System.Collections;

namespace LinqExercise
{
    internal class MyEnumeratorList: IEnumerator<int>
    {
        public IList enumerator = new List<int>();
        private readonly int size;
        private int[] array;
        private int index = -1;

            public MyEnumeratorList(int size)
            {
            this.size = size;
            this.array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    array[i] = i + 1;
                }
        }
        public int Current => array[index];

        object IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext()
            {
            if (index < size - 1)
            {
            index ++;
            return true;
            }
            return false;
            }

            public void Reset()
            {
            index = -1;
            }

        public void Dispose()
        {
        }

        public static implicit operator List<object>(MyEnumeratorList v)
        {
            throw new NotImplementedException();
        }
    }
}
