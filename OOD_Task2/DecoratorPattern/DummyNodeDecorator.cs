namespace OOD_Task2.DecoratorPattern
{
    class DummyNodeDecorator:INodeDecorator
    {
        protected INodeDecorator node;
        public DummyNodeDecorator(INodeDecorator node)
        {
            this.node = node;
        }

        public virtual string DecorateNode()
        {
            return node.DecorateNode();
        }
    }
}
