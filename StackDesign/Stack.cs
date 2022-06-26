using System;
using System.Collections.Generic;

namespace StackDesign
{
    public class Stack
    {
        private readonly List<object> _listOfObjects = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("It's not possible to add a null object to the Stack.");

            _listOfObjects.Add(obj);
            Console.WriteLine(obj);
        }

        public object Pop()
        {
            if (_listOfObjects == null || _listOfObjects.Count == 0)
                throw new InvalidOperationException("Pop is not possible since there are no elements in the Stack.");

            int index = _listOfObjects.Count - 1;
            object returnObj = _listOfObjects[index];
            _listOfObjects.RemoveAt(index);
            return returnObj;
        }

        public void Clear()
        {
            _listOfObjects.Clear();
        }
    }
}