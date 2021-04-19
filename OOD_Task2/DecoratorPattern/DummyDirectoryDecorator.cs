namespace OOD_Task2.DecoratorPattern
{
    using Task2;
    class DummyDirectoryDecorator : DummyNodeDecorator
    {
        public DummyDirectoryDecorator(INodeDecorator node) : base(node) { }

        public override string DecorateNode()
        {
            return node.DecorateNode() + EndsWithChiper((DummyNode)node);
        }

        public string EndsWithChiper(DummyNode n)
        {
            string reverseContent = "";
            if (n.Name.EndsWith(".cipher"))
            {
                int len;
                len = n.GetPrintableContent().Length - 1;

                while (len >= 0)
                {
                    reverseContent += n.GetPrintableContent()[len] - 25;
                    len--;
                }
            }
            return reverseContent;
        }
    }
}
