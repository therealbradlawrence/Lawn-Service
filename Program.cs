using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many invoices do you want to add? ");
        var numberOfInvoices = int.Parse(Console.ReadLine());

        var invoiceList = new List<LawnService>();
        for (int i = 0; i < numberOfInvoices; i++)
        {
            var lawnService = new LawnService();

            Console.WriteLine("Enter the name of the customer: ");
            lawnService.Name = Console.ReadLine();

            Console.WriteLine("Enter the address of the customer: ");
            lawnService.Address = Console.ReadLine();

            Console.WriteLine("Enter the price: ");
            lawnService.Price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the amount of time it took in minutes to complete this job: ");
            lawnService.Time = int.Parse(Console.ReadLine());

            Console.WriteLine("Is the job complete? (true or false): ");
            lawnService.Complete = bool.Parse(Console.ReadLine());

            invoiceList.Add(lawnService);
        }

        Console.WriteLine("\nLawn Service Invoice(s):");
        foreach (var record in invoiceList)
        {
            Console.WriteLine(record.ToString());
        }
    }
}
