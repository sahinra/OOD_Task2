namespace OOD_Task2.IteratorPattern
{
    using Task2;

    interface TreeCollection
    {
        DummyNode BreathFirstSearch(DummyNode root);
        DummyNode DepthFirstSearch(DummyNode root);
    }
}
