public class Warehouse {
    public string Name { get; private set; }
    public List<Product> Products { get; private set; } = new List<Product>();

    public Warehouse(string name) {
        Name = name;
    }
}
