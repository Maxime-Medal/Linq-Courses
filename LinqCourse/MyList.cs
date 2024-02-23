using System.Collections;

namespace LinqExercise
{
    public class MyList : IEnumerable<int>
    {
        private readonly MyEnumeratorList _myList;
        public MyList(int size)
        {
            this._myList = new MyEnumeratorList(size);
        }

        public IEnumerator<int> GetEnumerator()
        {
            return _myList;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
