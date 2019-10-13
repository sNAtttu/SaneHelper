using Microsoft.VisualStudio.TestTools.UnitTesting;
using SaneHelper;
using System;

namespace SaneHelperUnitTests
{
    [TestClass]
    public class ServiceFactoryUnitTests
    {
        private readonly string folderArgument = "folder";
        private readonly string invalidArgument = "perse";

        [TestMethod]
        public void ServiceFactoryShouldReturnFolderService()
        {
            string[] args = new string[1] { folderArgument };
            SaneHelper.Interfaces.IExecutable createdClass = ServiceFactory.CreateExecutableClass(args);
            Assert.IsInstanceOfType(createdClass, typeof(SaneHelper.Services.FolderService));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ServiceFactoryShouldThrowWhenInvalidArgument()
        {
            string[] args = new string[1] { invalidArgument };
            ServiceFactory.CreateExecutableClass(args);
        }
    }
}
