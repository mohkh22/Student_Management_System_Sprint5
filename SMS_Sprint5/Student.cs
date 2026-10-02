namespace SMS_Sprint5
{
    public class Student:Person
    {
        private double _gpa; 

        public double GPA
        {
            get { return _gpa; }
            set
            {
                if (value >= 0 && value <= 4)
                {
                    _gpa = value;
                }
                else
                {
                    throw new ArgumentException("GPA must be between 0 and 4.");
                }
            }
        }

        public static int StudentCount { get; private set; } = 0;


        public Student():this("Unknown", 0, 0)
        {
           
        }
        public Student(string? name, int age, double gpa):base(name, age)
        {
            GPA = gpa;
            StudentCount++;
        }

        public Student(Student student) : base(student.Name, student.Age)
        {
            GPA = student.GPA;
            StudentCount++;
        }


        public string CalculateGrade()
        {
            if(_gpa >= 3.5)
            {
                return "Excellent";
            }
            else if (_gpa >= 3.0)
            {
               return "Very Good";
            }
            else if (_gpa >= 2.5)
            {
                return "Good";
            }
            else if (_gpa >= 2.0)
            {
                return "Pass";
            }
            else
            {
                return "Fail";
            }
        }


        public override void PrintInfo()
        {
            base.PrintInfo(); 
            Console.WriteLine($", GPA: {GPA}, Grade: {CalculateGrade()}");
        }
    }
}
