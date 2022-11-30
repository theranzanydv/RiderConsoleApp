namespace ConsoleApp3.Week5;

public static class Employee
{
    public static void EmployeeDetails()
    {
        List<EmployeeModel> list = new List<EmployeeModel>
        {
            new EmployeeModel { Name = "Joker", Address = "Kathmandu", Number = 123, IsTemp = false },
            new EmployeeModel { Name = "Ball", Address = "Kathmandu", Number = 123, IsTemp = false },
            new EmployeeModel { Name = "Fish", Address = "Kathmandu", Number = 123, IsTemp = false },
            new EmployeeModel { Name = "Goat", Address = "Kathmandu", Number = 123, IsTemp = true },
            new EmployeeModel { Name = "Cat", Address = "Kathmandu", Number = 123, IsTemp = false },
            new EmployeeModel { Name = "Dog", Address = "Kathmandu", Number = 123, IsTemp = true },
            new EmployeeModel { Name = "Elf", Address = "Kathmandu", Number = 123, IsTemp = true },
            new EmployeeModel { Name = "Apple", Address = "Kathmandu", Number = 123, IsTemp = true },
            new EmployeeModel { Name = "Horse", Address = "Kathmandu", Number = 123, IsTemp = true },
            new EmployeeModel { Name = "Ink", Address = "Kathmandu", Number = 123, IsTemp = true },
        };

        // Searching
        Console.WriteLine("This is Searching");
        List<EmployeeModel> searchList = list.Where(z => !z.IsTemp).ToList();
        Console.WriteLine("Searching");
        Console.WriteLine(searchList.Select(x => x.Name).FirstOrDefault());


        // Sorting
        Console.WriteLine("\nThis is sorting");
        List<EmployeeModel> sortedList = list.OrderBy(z => z.Name).ToList();
        foreach (var item in sortedList)
        {
            Console.WriteLine($"The sorted Names are {item.Name} and they were created at {item.CreatedAt}");
        }
    }
}