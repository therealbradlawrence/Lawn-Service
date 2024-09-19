public class CustomerInfo
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Time { get; set; }
    public string Address { get; set; }

    public override string ToString()
    {
        return $"Customer Name: {Name}, Customer Address: {Address}, Price: {Price}, Mowing Time: {Time} Minutes";
    }
}

