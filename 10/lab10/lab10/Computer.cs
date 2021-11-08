using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Computer<T> : IList<T>
    {
        public T Id { get; set; }
        public string CpuName { get; set; }
        public string GpuName { get; set; }
        public int RamValue { get; set; }

      

        public Computer() { }
        public Computer(int id, string cpuName, string gpuName, int ramValue)
        {
            object o = id;
            Id = (T)o;
            CpuName = cpuName;
            GpuName = gpuName;
            RamValue = ramValue;
        }


        public override string ToString()
        {
            return $"Id {Id} CPU {CpuName} GPU {GpuName} Ram {RamValue}";
        }


        #region interface

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
