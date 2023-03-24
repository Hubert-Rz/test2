

namespace test2
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;
        public EmployeeInMemory(string name, string surname, char sex)
        : base(name, surname, sex)

        {

        }
        private List<float> grades = new List<float>();

        public override void AddGrade()
        {
            throw new NotImplementedException();
        }


        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100f);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80f);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60f);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40f);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20f);
                    break;
                default:
                    throw new Exception("Wrong Letter");


            }
        }

        public override void AddGrade(decimal grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(string grade)
        {
            if (grade.Length == 1)
            {
                char resultChar = grade[0];
                switch (resultChar)
                {

                    case 'A':
                    case 'a':
                    case 'B':
                    case 'b':
                    case 'C':
                    case 'c':
                    case 'D':
                    case 'd':
                    case 'E':
                    case 'e':
                        this.AddGrade(resultChar);
                        break;
                    default:

                        if (float.TryParse(grade, out float result))
                        {
                            this.AddGrade(result);

                        }
                        else
                        {
                            throw new Exception("String is not float");

                        }
                        break;
                }
            }
            else
            {
                if (float.TryParse(grade, out float result))
                {
                    this.AddGrade(result);

                }
                else
                {
                    throw new Exception("String is not float");

                }
            }
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("invalid grade value");

            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }


            return statistics;
        }
    }
}
