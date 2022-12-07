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
            bool output = UserDetails.PassMin8CharAnd1UpperCase(userInput);      //UC5 pass min 8 char and 1 uppercase

            //Assert
            Assert.AreEqual(output, true);
        }
    }
}