Probe.Run();
Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
Hero sergey = new Hero("Сергей", 110);

alexander.TakeDamage(10);
alexander.Heal(10);

Guild guild = new Guild("Гильдия героев");
guild.Heroes.Add(yaroslav);
guild.Heroes.Add(anastasia);
guild.Heroes.Add(artem);
guild.Heroes.Add(alexander);
guild.Heroes.Add(sergey);

Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.Heroes.Count}");

if (guild.Heroes.Count > 0) {
    Console.WriteLine($"Первый: {guild.Heroes[0].Name}");
    Console.WriteLine($"Последний: {guild.Heroes[guild.Heroes.Count - 1].Name}");
}

Console.WriteLine();
foreach (Hero hero in guild.Heroes) {
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}

int strongCount = 0;
foreach (Hero hero in guild.Heroes) {
    if (hero.Health >= 120) {
        strongCount += 1;
    }
}
Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {strongCount}");

if (guild.Heroes.Count > 0) {
    Hero strongest = guild.Heroes[0];
    foreach (Hero hero in guild.Heroes) {
        if (hero.Health > strongest.Health) {
            strongest = hero;
        }
    }
    Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
}

if (guild.Heroes.Count > 0) {
    int totalHealth = 0;
    foreach (Hero hero in guild.Heroes) {
        totalHealth += hero.Health;
    }
    int averageHealth = totalHealth / guild.Heroes.Count;

    int aboveAverageCount = 0;
    foreach (Hero hero in guild.Heroes) {
        if (hero.Health > averageHealth) {
            aboveAverageCount += 1;
        }
    }
    Console.WriteLine($"Среднее здоровье: {averageHealth}, здоровее среднего: {aboveAverageCount}");
}

Console.WriteLine();
Warehouse warehouse = new Warehouse("Оружейный склад гильдии");

Product shield = new Product("Железный щит", 800, 10);
Product sword = new Product("Стальной меч", 1200, 2);
Product potion = new Product("Зелье лечения", 150, 15);

warehouse.Products.Add(shield);
warehouse.Products.Add(sword);
warehouse.Products.Add(potion);

Console.WriteLine($">>> {warehouse.Name} <<<");

Console.WriteLine($"Всего позиций: {warehouse.Products.Count}");
if (warehouse.Products.Count > 0) {
    Console.WriteLine($"Первый товар: {warehouse.Products[0].Name}");
    Console.WriteLine($"Последний товар: {warehouse.Products[warehouse.Products.Count - 1].Name}");
}

Console.WriteLine();
foreach (Product item in warehouse.Products) {
    Console.WriteLine($"Товар: {item.Name} | Цена: {item.Price} | Остаток: {item.StockQuantity} шт.");
}

Product bow = new Product("Охотничий лук", 950, 1);
warehouse.Products.Add(bow);

Console.WriteLine($"\nПосле поступления нового товара (всего позиций: {warehouse.Products.Count}):");
foreach (Product item in warehouse.Products) {
    Console.WriteLine($"Товар: {item.Name} | Цена: {item.Price} | Остаток: {item.StockQuantity} шт.");
}

int lowStockCount = 0;
foreach (Product item in warehouse.Products) {
    if (item.StockQuantity < 3) {
        lowStockCount += 1;
    }
}
Console.WriteLine($"\nТоваров с критическим остатком (меньше 3 шт.): {lowStockCount}");

shield.Sell(4);
Console.WriteLine($"Продано 4 щита через переменную shield. Остаток в списке warehouse.Products: {warehouse.Products[0].StockQuantity} шт.");
