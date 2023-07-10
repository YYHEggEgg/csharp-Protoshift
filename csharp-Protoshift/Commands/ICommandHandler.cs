using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.Commands
{
    internal interface ICommandHandler
    {
        public string CommandName { get; }
        /// <summary>
        /// A brief and one-line description of this command.
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// Basic usage of this command. You can put multiple lines here.
        /// </summary>
        public string Usage { get; }
        /// <summary>
        /// Command Handler. Note that the method may invoke Log.Info or so on to output messages. The Command Dispatch won't do it.
        /// </summary>
        /// <param name="args"></param>
        public Task HandleAsync(string[] args);
        public void CleanUp();
    }
}
