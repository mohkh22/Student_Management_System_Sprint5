using SMS_Sprint5;

Student student1 = new Student(); 

Student student2 = new Student("Alice", 20, 3);
Student student3 = new Student("Bob", 22, 3.5);

Student student4 = new Student(student2);

student4.Name = "Mohamed";

Person person1= new Person("John", 30);

List<Person> people = new List<Person>();

people.Add(person1);
people.Add(student1); 
people.Add(student2); 
people.Add(student3); 
people.Add(student4);


foreach (var item in people)
{
    Console.WriteLine($"\n{item.GetType().Name}");
    item.PrintInfo();
}

Console.WriteLine($"Student Count = {Student.StudentCount}");


try
{
    Student student5 = new Student("", 21, 4); // This will throw an exception beacause the name is empty
    Student student6 = new Student("Ahmed", -1, 3.2); // This will throw an exception because the age is negative
    Student student7 = new Student("Ahmed", 21, 5); // This will throw an exception because the GPA is out of bounds
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}


Console.ReadKey(); 