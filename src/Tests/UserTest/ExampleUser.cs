using Users;
using Xunit;

namespace UserTest
{
    public class ExampleUser
    {
        [Fact]
        public void UserIsOfLegalAge()
        {
            //Arrange
            var user = new User("William", 34);
            var expected = true;
            //Act
            var result = user.IsOfLegalAge();
            //Assert
            Assert.Equal(expected, result);
        }
    }
}