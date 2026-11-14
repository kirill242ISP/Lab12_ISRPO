public class Product {
    public string Name;
    public double Price;
    public int StockQuantity { get; private set; }

    public Product(string name, double price, int stockQuantity) {
        Name = name;
        Price = price;

        if (stockQuantity < 0) {
            StockQuantity = 0;
        } else {
            StockQuantity = stockQuantity;
        }
    }

    public void Restock(int amount) {
        if (amount <= 0) {
            return;
        }

        StockQuantity += amount;
    }

    public bool Sell(int amount) {
        if (amount <= 0 || amount > StockQuantity) {
            return false;
        }

        StockQuantity -= amount;
        return true;
    }

    public double CalculateTotalCost(int quantity) {
        return Price * quantity;
    }
}
