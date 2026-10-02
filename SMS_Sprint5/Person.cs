namespace SMS_Sprint5
{
    public class Person
    {
        private string? _name; 
        protected int _age;

        public string? Name
        {
            get { return _name;  }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                else
                {
                    _name = value;
                }
            }
        }


        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("Age cannot be negative.");
                }
            }
        }



        public Person():this("Unknown", 0)
        {
           
        }

        public Person(string? name, int age)
        {
            Name = name;
            Age = age;
        }


        public Person(Person person):this(person.Name, person.Age )
        {
            
        }


        public virtual void PrintInfo()
        {
            Console.Write($"Name: {Name}, Age: {Age}  ");
        }
    }
}
