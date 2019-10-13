using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaneHelper.Interfaces;

#nullable enable
namespace SaneHelper.Services
{
    class FolderService: IExecutable
    {
        private List<string> passedArguments;
        public FolderService(string[] args)
        {
            passedArguments = args.ToList();
        }

        public void ExecuteAction()
        {
            Console.WriteLine("Opening folder: ");
            Console.WriteLine(passedArguments[1]);
        }
    }
}
