namespace Kodetime09._05
{
    public interface ISoda
    {
        string Name { get; }
        int Price { get; }
        int Inventory { get; set; }

        void Print();
    }
}