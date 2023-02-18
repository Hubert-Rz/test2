using test2;

namespace TestProject1
{
    public class Tests
    {
     

        [Test]
        public void WhenAddScoreToEmploye_ThenGetCorrectSum()
        {
            //arange
            var employee = new Employee("Hubert","Rz¹¿ewski",49);
            employee.AddScore(3);
            employee.AddScore(12);
            employee.AddScore(6);
            //act
            var result = employee.Result;
            //assert
            Assert.AreEqual(21, result);
        }

        [Test]
        public void WhenAddOrSubScoreToEmploye_ThenGetCorrectSum()
        {
            //arange
            var employee = new Employee("Hubert", "Rz¹¿ewski", 49);
            employee.AddScore(3);
            employee.AddScore(12);
            employee.AddScore(6);
            employee.SubScore(6);
            employee.SubScore(2);
            //act
            var result = employee.Result;
            //assert
            Assert.AreEqual(13, result);
        }
    }
}