using RegexDay20Assignment;

namespace RegexMSTest
{
    [TestClass]
    public class UserRegistrationTestClass
    {
        [TestMethod]
        [DataRow("Abc45678")]    //pass
        [DataRow("Abcd567890")]   //pass
        [DataRow("a2345678")]     //fail
        [DataRow("Abc123")]    //fail
        public void TestFirstName(string userInput)
        {
            //Arrange
            //string userInput = "Abc";

            //Act
            bool output = UserDetails.UpperCase1AndNumeric1(userInput);      //UC7 min 8 char ,1 upper case ,i numeric.

            //Assert
            Assert.AreEqual(output, true);
        }
    }
}