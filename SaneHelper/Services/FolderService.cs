using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using SaneHelper.Interfaces;

#nullable enable
namespace SaneHelper.Services
{
    public class FolderService: IExecutable
    {
        private List<string> passedArguments;

        private readonly string explorer = "explorer.exe";

        public FolderService(string[] args)
        {
            passedArguments = args.ToList();
        }

        public void ExecuteAction()
        {
            OpenFolder(passedArguments[1]);
        }

        private void OpenFolder(string folder)
        {
            switch (folder)
            {
                case "humble":
                    Process.Start(explorer, @"E:\HumbleBundle_GraphicAssets");
                    break;
                default:
                    throw new ArgumentException("Invalid folder given in arguments");
            }
        }

    }
}
