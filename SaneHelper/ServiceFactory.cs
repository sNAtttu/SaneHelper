using SaneHelper.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using SaneHelper.Utilities;
using SaneHelper.Services;

namespace SaneHelper
{
    public class ServiceFactory
    {
        public static IExecutable CreateExecutableClass(string[] args) => args[0] switch
        {
            "folder" => new FolderService(args),
            "game" => new GameService(args),
            _ => throw new InvalidOperationException("Unsupported action")
        };
    }
}
