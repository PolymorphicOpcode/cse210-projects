class Program {
    static void Main(string[] args) {
        var p = new Person("Jimmy John");
        var jim = new Student();
        Console.WriteLine(jim.GetName());

    }
}
// parent class/superclass/base class - person
class Person {
    private string _name = "N/A";

    public Person(string name) {
        _name = name;
    }
    public string GetName() {
        return _name;
    }
}
// child class/subclass - student
class Student: Person {
}