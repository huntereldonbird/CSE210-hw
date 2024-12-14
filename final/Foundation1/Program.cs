using System;
using Foundation1;
using System.Text.Json;

class Program
{
    static void Main(string[] args) {
        
        
        Console.WriteLine(DateTime.Now.ToString());
        
    }

    static void THIS() {
        
        var ticket = File.ReadAllText("ticket.json");
        
        test igd = JsonSerializer.Deserialize<test>(ticket);
        
        Console.WriteLine(igd.OrderName);
        
        
        
    }

    static void THIS2() {
        MenuItemTest[] menuItemTests = {
            new MenuItemTest(MenuItemTest.MenuType.entre, 10, 10, DateTime.Now),
            new MenuItemTest(MenuItemTest.MenuType.entre, 10, 10, DateTime.Now)
        };

        test t = new test(menuItemTests, 1, "hiya", true, DateTime.Now);

        var options = new JsonSerializerOptions();

        options.WriteIndented = true;

        string tjson = JsonSerializer.Serialize<test>(t, options);
        
        Console.WriteLine(tjson);
        File.WriteAllText("ticket.json", tjson);
    }
}