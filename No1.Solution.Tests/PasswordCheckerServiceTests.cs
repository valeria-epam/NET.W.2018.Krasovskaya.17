using Moq;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTests
    {
        [Test]
        public void Verify()
        {
            var checker = new Mock<IRepository>();
            var verify = new VerifyPassword();

            var passwordChecker = new PasswordCheckerService(checker.Object, verify);


            var (success, message) = passwordChecker.VerifyPassword("");

            Assert.AreEqual((false, " is empty "), (success, message));
        }
    }
}
