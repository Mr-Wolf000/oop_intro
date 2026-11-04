List<Person> list = new List<Person>();
list.Add(new Person("Tobias",20,"010101-0101"));
list.Add(new Person("Magnus",19,"743856-2353"));
list.Add(new Person("Simon",25,"849274-2353"));
list.Add(new Person("Frost",42,"829374-4352"));
list.Add(new Person("David",26,"123556-7890"));

foreach (Person person in list) {
    if (person.GetCpr() == "010101-0101") {
        Console.WriteLine(person);
    }
}

Dictionary<string,Person> dictionary = new Dictionary<string,Person>();
dictionary.Add("010101-0101",new Person("Tobias",22,"010101-0101"));
dictionary.Add("843625-2324",new Person("Frost",75,"843625-2324"));
dictionary.Add("738264-3254",new Person("Magnus",52,"738264-3254"));
dictionary.Add("8439573-8433",new Person("David",24,"8439573-8433"));
dictionary.Add("343954-3284",new Person("Davis",54,"343954-3284"));

Console.WriteLine(dictionary["010101-0101"]);


class Person {
    string name;
    int age;
    string cpr;

    public string GetName() {
        return name;
    }
    public int GetAge() {
        return age;
    }
    public string GetCpr() {
        return cpr;
    }
    public override string ToString() {
        return($"Name: {name}\nAge: {age}\nCpr: {cpr}");
    }
    public Person(string name, int age, string cpr) {
        this.name = name;
        this.age = age;
        this.cpr = cpr;
    }
}