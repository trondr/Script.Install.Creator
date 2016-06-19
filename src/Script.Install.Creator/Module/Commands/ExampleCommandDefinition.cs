﻿using Common.Logging;
using NCmdLiner.Attributes;
using Script.Install.Creator.Library.Infrastructure;
using Script.Install.Creator.Library.Module.Commands.Example;

namespace Script.Install.Creator.Module.Commands
{
    public class ExampleCommandDefinition: CommandDefinition
    {
        private readonly IExampleCommandProvider _exampleCommandProvider;
        private readonly ILog _logger;

        public ExampleCommandDefinition(IExampleCommandProvider exampleCommandProvider, ILog logger)
        {
            _exampleCommandProvider = exampleCommandProvider;
            _logger = logger;
        }

        [Command(Description = "Just an example command. To be deleted or renamed for your own use")]
        public int CreateSomething(
            [RequiredCommandParameter(Description = "Just an example parameter.", AlternativeName = "xp", ExampleValue = @"c:\temp")]
            string exampleParameter
            )
        {            
            return _exampleCommandProvider.Create(exampleParameter);
        }
    }
}
