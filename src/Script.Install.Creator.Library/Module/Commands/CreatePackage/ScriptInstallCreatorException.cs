using System;
using System.Runtime.Serialization;

namespace Script.Install.Creator.Library.Module.Commands.CreatePackage
{
    public class ScriptInstallCreatorException : Exception
    {
        public ScriptInstallCreatorException()
            : base()
        {
        }

        public ScriptInstallCreatorException(string message)
            : base(message)
        {
        }

        public ScriptInstallCreatorException(string message, Exception exception)
            : base(message, exception)
        {
        }

        protected ScriptInstallCreatorException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}