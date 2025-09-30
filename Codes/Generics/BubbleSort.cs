using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class BubbleSort<T>
        where T : INumber<T>
    {
        public T[] Items { get; private set; }

        public BubbleSort(T[] items)
        {
            Items = items;
        }

        public void Sort()
        {
            T temp;

            for (int j = 0; j <= Items.Length - 2; j++)
            {
                for (int i = 0; i <= Items.Length - 2; i++)
                {
                    if (Items[i] > Items[i + 1])
                    {
                        temp = Items[i + 1];
                        Items[i + 1] = Items[i];
                        Items[i] = temp;
                    }
                }
            }
        }
    }
}
