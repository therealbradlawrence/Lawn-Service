internal class LawnService : CustomerInfo
{
    public bool Complete { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", Is this job complete? {Complete}";
    }
}