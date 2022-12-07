using RegexDay20Assignment;

namespace RegexMSTest
{
    [TestClass]
    public class UserRegistrationTestClass
    {
        [TestMethod]
        [DataRow("Abc@45678")]    //pass
        [DataRow("Abc#567890")]   //pass
        [DataRow("Aa%@5678")]     
        [DataRow("@!@!Abc123")]    
        public void TestFirstName(string userInput)
        {
            //Arrange
            //string userInput = "Abc";

            //Act
            bool output = UserDetails.SpecialCharacter1(userInput);      //UC8 min 8 char , exactly 1 special char 

            //Assert
            Assert.AreEqual(output, true);
        }
    }
}