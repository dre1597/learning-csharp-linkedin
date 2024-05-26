namespace learn_csharp.classes;

public class Book5
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int PageCount { get; }

    public Book5(string name, string author, int pages) {
        Name = name;
        Author = author;
        PageCount = pages;
    }

    public override string ToString() {
        return $"Book: {Name} by {Author}";
    }

    public string ToString(char format) {
        if (format == 'B') {
            return $"Book: {Name}:{Author}";
        }
        else if (format == 'F') {
            return $"Book: {Name} by {Author} is {PageCount} pages";
        }
        else {
            return ToString();
        }
    }
}
