namespace Ex6_TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("AA44A")]
        [DataRow("Aaa88aa")]
        [DataRow("aaaaaaaaaaaa")]
        public void ValidPasswordLenght(string s)
        {
            // Arrange & Act
            bool flag = projecteProva2.Program.ValidPaswordLenght(s);

            // Assert
            Assert.IsTrue(flag);
        }
        [TestMethod]
        [DataRow("a")]
        [DataRow("aaaaaaaaaaaaaaaaaa")]
        [DataRow("0000000000000000000000000000000000000000000000000000000000")]
        public void InvalidPasswordLenght(string s)
        {
            // Arrange & Act
            bool flag = projecteProva2.Program.ValidPaswordLenght(s);

            // Assert
            Assert.IsFalse(flag);
        }
        [TestMethod]
        [DataRow("aeiou")]
        [DataRow("12345")]
        [DataRow("ABCDEFG")]
        public void ValidPasswordCharacters(string s)
        {
            // Arrange & Act
            bool flag = projecteProva2.Program.ValidPasswordCharacters(s);

            // Assert
            Assert.IsTrue(!flag);
        }
        [TestMethod]
        [DataRow("@eiou")]
        [DataRow("/////")]
        [DataRow("*ex*e^*")]
        public void InvalidPasswordCharacters(string s)
        {
            // Arrange & Act
            bool flag = projecteProva2.Program.ValidPasswordCharacters(s);

            // Assert
            Assert.IsFalse(!flag);
        }
    }
}