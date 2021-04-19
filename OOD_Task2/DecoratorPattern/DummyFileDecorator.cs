namespace OOD_Task2.DecoratorPattern
{
    using Task2;
    class DummyFileDecorator: DummyNodeDecorator
    {
        public DummyFileDecorator(INodeDecorator node) : base(node) { }

        public override string DecorateNode()
        {
            return node.DecorateNode() + PrintContent((DummyNode)node) + EndsWithChiper((DummyNode)node);
        }

        public string EndsWithChiper(DummyNode n)
        {
            if(!n.Name.EndsWith(".cipher"))
                return n.GetPrintableContent() + '\n';
            return n.GetPrintableContent();
        }

        public string PrintContent(DummyNode n)
        {
            return n.GetPrintableContent().Trim('-');
        }
    }
}
