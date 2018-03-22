using System;
using Demo.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoTest
{
    [TestClass]
    public class MathUnitTest
    {
        [TestMethod]
        public void AddTest()
        {
            // Arrange 

            var vm = new MathViewModel();
            vm.ValueA = 4;
            vm.ValueB = 6;

            //Act

            vm.AddCommand.Execute(null);

            //Assert
            Assert.IsTrue(vm.Result == 10, "vm.Result != 10 !");
        }
    }
}
