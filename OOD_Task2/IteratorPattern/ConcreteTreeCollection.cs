using System;
using Task2;

namespace OOD_Task2.IteratorPattern
{
    class ConcreteTreeCollection : TreeCollection
    {
        public DummyNode BreathFirstSearch(DummyNode node)
        {
            var printableContent = node.GetPrintableContent();
            if (printableContent != null)
            {
                Console.WriteLine(printableContent);
            }

            while(node.FirstChild.Next != null)
            { 
                if (printableContent != null)
                {
                    Console.WriteLine(printableContent);
                }
                node = node.FirstChild.Next;
            }

            //not completed 

            return node;
        }

        public DummyNode DepthFirstSearch(DummyNode node)
        {
            while (node.FirstChild != null)
            {
                var printableContent = node.GetPrintableContent();
                if (printableContent != null)
                {
                    Console.WriteLine(printableContent);
                }
                node = node.FirstChild;

                if (node.FirstChild == null)
                {
                    while (node.Next != null)
                    {
                        if (printableContent != null)
                        {
                            Console.WriteLine(printableContent);
                        }
                        node = node.Next;

                        if (node.Next == null)
                        {
                            node = node.Parent;
                        }
                    }
                }
            }

            //not completed

            return node;
        }
    }
}
