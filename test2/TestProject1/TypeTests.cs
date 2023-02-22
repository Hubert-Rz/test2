
using test2;

namespace TestProject1
{
    public class TypeTests
    {
        [Test]
        public void WhenCompareParametersTwoTypeRef_ThenTypeBeTheSame()
        {
            //arange
            var employee1 = GetEmploye("Hubert", "Rzazewski", 49);
            var employee2 = GetEmploye("Hubert", "Nowak", 49);

            //act

            //assert
            Assert.AreEqual(employee1.Name, employee2.Name);
        }
        [Test]
        public void WhenCompareTwoTypeRef_ThenTypeNotBeTheSame()
        {
            //arange
            var employee1 = GetEmploye("Hubert", "Rzazewski", 49);
            var employee2 = GetEmploye("Hubert", "Nowak", 49);

            //act

            //assert
            Assert.AreNotEqual(employee1, employee2);
        }
        [Test]
        public void WhenCompareTwoTypeInt_ThenTypeBeTheSame()
        {
            //arange
            int number1 = 2;
            int number2 = 2;

            //act

            //assert
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void WhenCompareTwoTypeFloat_ThenTypeBeTheSame()
        {
            //arange
            float number1 = 2000000000000000000;
            float number2 = 2000000000000000000;

            //act

            //assert
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void WhenCompareTwoTypeString_ThenTypeBeTheSame()
        {
            //arange
            string str1 = "lato";
            string str2 = "lato";

            //act

            //assert
            Assert.AreEqual(str1, str2);
        }

        private Employee GetEmploye(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
