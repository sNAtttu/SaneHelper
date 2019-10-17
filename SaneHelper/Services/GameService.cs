using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaneHelper.Interfaces;
using SaneHelper.Games;

namespace SaneHelper.Services
{
    public class GameService : IExecutable
    {
        private List<string> passedArguments;
        public GameService(string[] args)
        {
            passedArguments = args.ToList();
        }

        public void ExecuteAction()
        {
            switch (passedArguments[1])
            {
                case "reaction":
                    ReflectionGame.Start();
                    break;
                default:
                    throw new ArgumentException("Unknown game");
            }
        }
    }
}
