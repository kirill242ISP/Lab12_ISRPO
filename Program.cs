Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);

alexander.TakeDamage(10);
alexander.Heal(10);

Console.WriteLine(">>> Участники готовы <<<");
Console.WriteLine();
Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());
Console.WriteLine($"Предел здоровья Александра: {alexander.MaxHealth}");

Console.WriteLine();
Product shield = new Product("Железный щит", 800, 10);
Console.WriteLine($"Товар: {shield.Name}, остаток: {shield.StockQuantity}");

shield.Sell(4);
Console.WriteLine($"После продажи 4 шт.: {shield.StockQuantity}");

shield.Sell(50);
Console.WriteLine($"После попытки продать 50 шт.: {shield.StockQuantity}");

Product wrongShield = new Product("Сломанный щит", 800, -5);
Console.WriteLine($"Товар с неверным начальным остатком: {wrongShield.StockQuantity}");
