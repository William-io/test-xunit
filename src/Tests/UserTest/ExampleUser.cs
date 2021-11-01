using Users;
using Xunit;
using Xunit.Abstractions;

namespace UserTest
{
    public class ExampleUser
    {
        //Injects the ITestOutputHelper interface into the test class.
        ITestOutputHelper _output;
        public ExampleUser(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void UserIsOfLegalAge()
        {
            //Arrange
            var user = new User("William", 34);
            var expected = true;
            //Act
            var result = user.IsOfLegalAge();
            _output.WriteLine($"result:{result}");
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UserIsUnderLegalAge()
        {
            //Arrange
            var user = new User("Debora", 17);
            var expected = false;
            //Act
            var result = user.IsOfLegalAge();
            //Assert
            Assert.Equal(expected, result);
        }
    }
}