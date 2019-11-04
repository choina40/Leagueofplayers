using Microsoft.VisualStudio.TestTools.UnitTesting;
using League_of_players.ViewModels;

namespace UnitTesting.MSTest
{
    [TestClass]
    public class LoginUnitTest
    {
        [TestMethod]
        public void LoginTest1()
        {
            var vm = new LoginViewModel();

            vm.LoginusernameEntry = user1;

            vm.LoginCommand.Execute(null);

            Assert.IsTrue(App.username == "user1","username is user1")
        }
    }
}
