using System.Collections.Generic;

public partial class Person
{
    public Data Data { get; set; }

}

public partial class Data
{
    public List<Item> Items { get; set; }

}

public partial class Item
{
    public Identity Identity { get; set; }

    public string Firstname { get; set; }
    public string Surname { get; set; }
    public string Middlename { get; set; }
}

public partial class Identity
{
    public long Id { get; set; }
}
