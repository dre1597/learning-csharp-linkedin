namespace learn_csharp.classes;

public class Book2 : Publication
{
    private string _author;

    public Book2(string name, string author, int pagecount, decimal price)
        : base(name, pagecount, price) {
        _author = author;
    }

    public string Author {
        get => _author;
        set => _author = value;
    }

    public override string GetDescription() {
        return $"{Name} by {Author}, {PageCount} pages";
    }
}
