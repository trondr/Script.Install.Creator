using Common.Logging;
using NCmdLiner.Attributes;
using Script.Install.Creator.Library.Infrastructure;
using Script.Install.Creator.Library.Module.Commands.CreatePackage;

namespace Script.Install.Creator.Module.Commands
{
    public class CreatePackageCommandDefinition: CommandDefinition
    {
        private readonly ICreatePackageCommandProvider _createPackageCommandProvider;
        private readonly ILog _logger;

        public CreatePackageCommandDefinition(ICreatePackageCommandProvider createPackageCommandProvider, ILog logger)
        {
            _createPackageCommandProvider = createPackageCommandProvider;
            _logger = logger;
        }

        [Command(Description = "Create script install package from script install template and input msi file, exe file or folder.")]
        public int CreatePackage(
            [RequiredCommandParameter(Description = "Setup source. Typically an msi file, exe file or folder.", AlternativeName = "ss", ExampleValue = @"c:\temp\SomeSetup.msi")]
            string setupSource,
            [OptionalCommandParameter(Description = "Packages folder, where new package will be created.", AlternativeName = "tf", ExampleValue = @"c:\temp\Packages", DefaultValue = null)]
            string packagesFolder
            )
        {
            return _createPackageCommandProvider.CreatePackage(setupSource, packagesFolder);
        }
    }
}
