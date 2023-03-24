


//using System.Xml.Linq;

//namespace test2
//{
//    public class Employee : IEmployee
//    {
//        private List<float> grades = new List<float>();

//        public override event EmployeeBase.GradeAddedDelegate GradeAdded;

//        public Employee(string name, string surname, char sex)

//        {
//            this.Name= name;
//            this.Surname= surname;
//            this.Sex=sex;
//        }
//        public Employee()
//        : this("no name", "no surname", '?')

//        {
//            this.Name = "no name";
//            this.Surname = "no surname" ;
//            this.Sex = '?';
//        }



//        public void AddGrade(float grade)
//        {
//            if (grade >= 0 && grade <= 100)
//            {
//                this.grades.Add(grade);
//            }
//            else
//            {
//                throw new Exception("invalid grade value");

//            }
//        }
//        public void AddGrade(string grade)
//        {
//            if (grade.Length == 1)
//            {
//                char resultChar = grade[0];
//                switch (resultChar)
//                {

//                    case 'A':
//                    case 'a':
//                    case 'B':
//                    case 'b':
//                    case 'C':
//                    case 'c':
//                    case 'D':
//                    case 'd':
//                    case 'E':
//                    case 'e':
//                        this.AddGrade(resultChar);
//                        break;
//                    default:

//                        if (float.TryParse(grade, out float result))
//                        {
//                            this.AddGrade(result);
//                        }
//                        else
//                        {
//                            throw new Exception("String is not float");

//                        }
//                        break;
//                }
//            }
//            else
//            {
//                if (float.TryParse(grade, out float result))
//                {
//                    this.AddGrade(result);
//                }
//                else
//                {
//                    throw new Exception("String is not float");

//                }
//            }
//        }
//        public void AddGrade(double grade)
//        {
//            float result = (float)grade;
//            this.AddGrade(result);

//        }
//        public void AddGrade(long grade)
//        {
//            float result = (float)grade;
//            this.AddGrade(result);
//        }
//        public void AddGrade(decimal grade)
//        {
//            float result = (float)grade;
//            this.AddGrade(result);
//        }
//        public void AddGrade(char grade)
//        {
//            switch (grade)
//            {
//                case 'A':
//                case 'a':
//                    this.grades.Add(100);
//                    break;
//                case 'B':
//                case 'b':
//                    this.grades.Add(80);
//                    break;
//                case 'C':
//                case 'c':
//                    this.grades.Add(60);
//                    break;
//                case 'D':
//                case 'd':
//                    this.grades.Add(40);
//                    break;
//                case 'E':
//                case 'e':
//                    this.grades.Add(20);
//                    break;
//                default:
//                    throw new Exception("Wrong Letter");


//            }
//        }
//        public void AddGrade()
//        {
//            throw new Exception("You must enter a grade value!");
//        }

//        public string Name { get; private set; }
//        public string Surname { get; private set; }
//        public char Sex { get; private set; }
//        public Statistics GetStatistics()
//        {
//            var statistics = new Statistics();
//            statistics.Average = 0;
//            statistics.Max = float.MinValue;
//            statistics.Min = float.MaxValue;

//            foreach (var grade in this.grades)
//            {
//                statistics.Max = Math.Max(statistics.Max, grade);
//                statistics.Min = Math.Min(statistics.Min, grade);
//                statistics.Average += grade;
//            }

//            statistics.Average = statistics.Average / this.grades.Count;
//            switch (statistics.Average)
//            {
//                case var average when average >= 80:
//                    statistics.AverageLetter = 'A';
//                    break;
//                case var average when average >= 60:
//                    statistics.AverageLetter = 'B';
//                    break;
//                case var average when average >= 40:
//                    statistics.AverageLetter = 'C';
//                    break;
//                case var average when average >= 20:
//                    statistics.AverageLetter = 'D';
//                    break;
//                default:
//                    statistics.AverageLetter = 'E';
//                    break;
//            }
//            if (grades.Count == 0)
//            {
//                statistics.Max = 0;
//                statistics.Min = 0;
//                statistics.Average = 0;
//            }
//            return statistics;

//        }

//    }
//}

