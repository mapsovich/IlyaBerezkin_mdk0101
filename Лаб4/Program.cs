Person tom = new Person { name = "Tom", company = { title = "Microsoft" } };
tom.Print();          // Имя: Tom  Компания: Microsoft

class Person
{
    public string name;
    public Company company;
    public Person()
    {
        name = "Undefined";
        company = new Company();
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Компания: {company.title}");
}

class Company
{
    public string title = "Unknown";
}
