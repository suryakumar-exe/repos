using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts
{
    class QueueTask
    {
        public void QTask()
        {
            Queue myqueue = new Queue();
            myqueue.Enqueue(3);
            myqueue.Enqueue(31);
            myqueue.Enqueue(13);
            myqueue.Enqueue("This is string");
            myqueue.Enqueue("Another string");
            myqueue.Enqueue(55.5);
            myqueue.Enqueue(true);

            Console.WriteLine(myqueue.Peek());
            foreach(var i in myqueue)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("count {0}",myqueue.Count);
            Console.WriteLine("deqeue {0}", myqueue.Dequeue());
            Console.WriteLine("count {0}", myqueue.Count);
            Console.WriteLine("contains {0}", myqueue.Contains(13));
        }          
    }
}
