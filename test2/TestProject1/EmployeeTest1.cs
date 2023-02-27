using test2;

namespace TestProject1
{
    public class Tests
    {
     

        [Test]
        public void WhenAddGradeToEmploye_ThenGetCorrectMinGrade()
        {
            //arange
            var employee = new Employee("Hubert","Rz¹¿ewski");
            employee.AddGrade(3);
            employee.AddGrade(14);
            employee.AddGrade(6);
            employee.AddGrade(4);
            employee.AddGrade(8);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(3, statistics.Min);
        }

        [Test]
        public void WhenAddGradeToEmploye_ThenGetCorrectMaxGrade()
        {
            //arange
            var employee = new Employee("Hubert", "Rz¹¿ewski");
            employee.AddGrade(3);
            employee.AddGrade(14);
            employee.AddGrade(6);
            employee.AddGrade(4);
            employee.AddGrade(8);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(14, statistics.Max);
        }

        [Test]
        public void WhenAddGradeToEmploye_ThenGetCorrectAvarageGrade()
        {
            //arange
            var employee = new Employee("Hubert", "Rz¹¿ewski");
            employee.AddGrade(3);
            employee.AddGrade(14);
            employee.AddGrade(6);
            employee.AddGrade(4);
            employee.AddGrade(8);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(7, statistics.Average);
        }


    }
}