
namespace test2
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set; }

        public Supervisor(string name, string surname, char sex)

        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        public Supervisor()
        : this("no name", "no surname", '?')

        {
            this.Name = "no name";
            this.Surname = "no surname";
            this.Sex = '?';
        }


        public void AddGrade()
        {
            throw new Exception("You must enter a grade value!");
        }

        public void AddGrade(char grade)
        {
            throw new Exception("You must enter a grade value!");
        }

        public void AddGrade(decimal grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(string grade)
        {
            if (grade.Length == 1 || grade.Length == 2)
            {
                string gradeLeft = (string)grade.Substring(0, 1);
                string gradeRight = "";
                if (grade.Length == 2)
                {
                    gradeRight = (string)grade.Substring(1, 1);
                }
                float resultNumber = 0;
                float resultGrade = 0;
           
                switch(float.TryParse(gradeLeft, out float result), float.TryParse(gradeRight, out float result1))
                {
                    case (false, false) :
                        throw new Exception("Invalid grade value");
                        
                    case (true, true) :
                        throw new Exception("Invalid grade value");
                        
                    case (true, false):
                        resultNumber= result;
                        break;
                    case (false, true):
                        resultNumber= result1;
                        break;
                }

                if (resultNumber >= 1 && resultNumber <= 6)
                {
                    switch (resultNumber)
                    {
                        case 6:
                            resultGrade = 100;
                            break;
                        case 5:
                            resultGrade = 80;
                            break;
                        case 4:
                            resultGrade = 60;
                            break;
                        case 3:
                            resultGrade = 40;
                            break;
                        case 2:
                            resultGrade = 20;
                            break;
                        case 1:
                            resultGrade = 0;
                            break;
                        default:
                            resultGrade = 0;
                            break;
                    }
                }
                if ((gradeLeft == "-" || gradeRight == "-") && resultGrade > 0)
                {
                    resultGrade = resultGrade - 5;
                }
                else if (gradeLeft == "+" || gradeRight == "+" && resultGrade < 100)
                {
                    resultGrade = resultGrade + 5;
                }

                this.AddGrade(resultGrade);

            }
            else
            {
                if (float.TryParse(grade, out float result))
                {
                    throw new Exception("Invalid grade value");
                }
                else
                {
                    throw new Exception("String is not float");

                }
            }
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("invalid grade value");

            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;
            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            if (grades.Count == 0)
            {
                statistics.Max = 0;
                statistics.Min = 0;
                statistics.Average = 0;
            }
            return statistics;

        }
    }
}
