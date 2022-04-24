using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagriMerkezi
{
    public class PriorityQueue : IQueue
    {
        public object[] Queue;
        private int front = -1;
        private int size = 0;
        private int count = 0;
        public PriorityQueue(int size)//int size
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object o)
        {
            if (count == size)
            {
                throw new Exception("Queue is full");

            }
            if (IsEmpty())
            {
                front++;
                Queue[front] = o;
                count++;
            }
            else
            {
                int i;
                for (i = count - 1; i >= 0; i--)
                {
                    if ((int)o > (int)Queue[i])
                    {
                        Queue[i + 1] = Queue[i];
                    }
                    else
                        break;
                }
                Queue[i + 1] = o;
                front++;
                count++;
            }
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public object Peek()
        {
            return Queue[front];
        }

        public object Remove()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Queue is empty...");
            }
            object temp = Queue[front];
            front--;
            count--;
            return temp;
        }
    }
}
