namespace learn_csharp.classes;

public class Magazine : Publication
{
    private string _publisher;

    // use the base() keyword to initialize the base class
    public Magazine(string name, string publisher, int pagecount, decimal price)
        : base(name, pagecount, price) {
        _publisher = publisher;
    }

    public string Publisher {
        get => _publisher;
        set => _publisher = value;
    }
}
