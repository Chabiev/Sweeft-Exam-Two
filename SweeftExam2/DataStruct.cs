using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftExam2
{
    public class DataStruct<T>
    {      
        private Dictionary<T, int> index;
        public List<T> items;
            
        public DataStruct()
            : this(0)
        {

        }

        public DataStruct(int capacity)
        {
            this.index = new Dictionary<T, int>(capacity);
            this.items = new List<T>(capacity);
        }

        public DataStruct(IEnumerable<T> collection)
        {
            this.items = new List<T>(collection);
            this.index = this.items
                .Select((value, index) => new { value, index })
                .ToDictionary(pair => pair.value, pair => pair.index);
        }

        public bool Remove(T item)
        {
                
            int keyIndex = this.index[item];
            T lastItem = this.items[this.items.Count - 1];
            this.items[keyIndex] = lastItem;

            this.index[lastItem] = keyIndex;

            this.index.Remove(item);
            this.items.RemoveAt(this.items.Count - 1);

            return true;
        }
    }
}
