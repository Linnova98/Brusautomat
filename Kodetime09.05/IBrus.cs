namespace Kodetime09._05
{
    public interface IBrus
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Inventory { get; set; }
        public int Id { get; set; }

        void Print();
    }
}