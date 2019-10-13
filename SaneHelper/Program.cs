using SaneHelper.Interfaces;
using System;

namespace SaneHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            IExecutable executableClass = ServiceFactory.CreateExecutableClass(args);
            executableClass.ExecuteAction();
        }
    }
}
    