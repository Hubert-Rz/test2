using test2;

namespace TestProject1
{
    public class Tests
    {


        [Test]
        public void WhenAddGradeNumberOrLetterToEmploye_ThenGetCorrectMinGrade()
        {
            //arange
            var employee = new Employee();
            employee.AddGrade(3.1);
            employee.AddGrade("a");
            employee.AddGrade(6);
            employee.AddGrade(4);
            employee.AddGrade('c');
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(Math.Round(3.1, 2), Math.Round(statistics.Min,2));
        }

        [Test]
        public void WhenAddGradeNumberOrLetterToEmploye_ThenGetCorrectMaxGrade()
        {
            //arange
            var employee = new Employee();
            employee.AddGrade(3.1);
            employee.AddGrade("a");
            employee.AddGrade(6);
            employee.AddGrade(4);
            employee.AddGrade('c');
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(100, statistics.Max);
        }

        [Test]
        public void WhenAddGradeNumberOrLetterToEmploye_ThenGetCorrectAvarageGrade()
        {
            //arange
            var employee = new Employee();
            employee.AddGrade(3.1);
            employee.AddGrade("a");
            employee.AddGrade(6);
            employee.AddGrade(4);
            employee.AddGrade('c');
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(Math.Round(34.62, 2), Math.Round(statistics.Average), 2);
        }
        [Test]
        public void WhenAddGradeNumber1to6ToSupervisor_ThenGetCorrectAvarageGrade()
        {
            //arange
            var supervisor = new Supervisor();
            supervisor.AddGrade("-2");
            supervisor.AddGrade("3+");
            supervisor.AddGrade("6");
            supervisor.AddGrade("4");
            supervisor.AddGrade("1");
            
            //act
            var statistics = supervisor.GetStatistics();
            //assert
            Assert.AreEqual(Math.Round(44.00, 2), Math.Round(statistics.Average), 2);
        }

    }
}