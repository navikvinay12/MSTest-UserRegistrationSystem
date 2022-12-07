using RegexDay20Assignment;

namespace RegexMSTest
{
    [TestClass]
    public class UserRegistrationTestClass
    {
        [TestMethod]
        [DataRow("Abc")]    //pass
        [DataRow("Abcd")]   //pass
        [DataRow("Ab")]     //fail
        [DataRow("abc")]    //fail
        public void TestFirstName(string userInput)
        {
            //Arrange
            //string userInput = "Abc";

            //Act
            bool output = UserDetails.LastName(userInput);      //UC2 LastName starts with cap and has min 3 char.

            //Assert
            Assert.AreEqual(output, true);

        }
    }
}