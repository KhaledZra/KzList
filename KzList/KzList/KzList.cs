using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KzList
{
    internal class KzList<T>
    {
        private T[] _kzList;
        private int _length;
        private int _count;

        public int Count { get { return _count; } }
        public int Length { get { return _length; } }

        public KzList() // Initialize empty KzList
        {
            this._kzList = new T[0];
            this._length = 0;
            this._count = 0;
        }
        public KzList(int iSize) // Initialize KzList with specific size
        {
            this._length = iSize;
            this._kzList = new T[this._length];
            this._count = 0;
        }

        // Define the indexer to allow client code to use [] notation.
        // Source: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/
        public T this[int index]
        {
            get
            {
                if (index < _count && index > -1)
                {
                    return this._kzList[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index location is out of bounds!");
                }
            }
            set
            {
                if (index < _count && index > -1)
                {
                    this._kzList[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index location is out of bounds!");

                }
            }
        }

        public void Add(T input)
        {
            if (this._length == this._count)
            {
                if (this._length == 0)
                {
                    this._length += 3;
                    this._kzList = new T[this._length];
                    this._kzList[this._count] = input;
                    this._count++;
                }
                else
                {
                    T[] temp = new T[this._count];

                    for (int i = 0; i < this._count; i++)
                    {
                        temp[i] = this._kzList[i];
                    }

                    this._length += 3;
                    this._kzList = new T[this._length];

                    for (int i = 0; i < this._count; i++)
                    {
                        this._kzList[i] = temp[i];
                    }

                    this._kzList[this._count] = input;
                    this._count++;
                }
            }
            else
            {
                this._kzList[this._count] = input;
                this._count++;
            }
        }

        public void Remove(int index)
        {
            if (this._count == 0)
            {
                Console.WriteLine("Error: Attempting to modify empty KzList!");
            }
            else
            {
                if (this._count - 1 == index)
                {
                    this._count--;
                }
                else
                {
                    if (index < this._count && index > -1)
                    {
                        for (int i = index; i < this._count - 1; i++)
                        {
                            this._kzList[i] = this._kzList[i + 1];
                        }
                        this._count--;
                    }
                    else
                    {
                        Console.WriteLine("Error: Index was out of count range!");
                    }
                }
            }
        }
    }
}
