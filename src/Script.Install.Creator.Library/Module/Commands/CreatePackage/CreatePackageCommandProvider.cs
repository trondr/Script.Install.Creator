using System.Collections.Generic;
using Script.Install.Creator.Library.Infrastructure;

namespace Script.Install.Creator.Library.Module.Commands.CreatePackage
{
    public class CreatePackageCommandProvider : CommandProvider, ICreatePackageCommandProvider
    {
        private readonly IEnumerable<IPackageCreator> _packageCreators;

        public CreatePackageCommandProvider(IEnumerable<IPackageCreator> packageCreators)
        {
            _packageCreators = packageCreators;
        }

        public int CreatePackage(string sourceSetupPath, string packagesFolder)
        {
            var returnValue = 1;
            bool wasCreated = false;
            foreach (var packageCreator in _packageCreators)
            {
                if(packageCreator.CanHandle(sourceSetupPath))
                {
                    packageCreator.CreatePackage(sourceSetupPath);
                    wasCreated = true;
                    break;
                }
            }
            if(!wasCreated)
            {
                throw new ScriptInstallCreatorException("Not able to create package for source path: " + sourceSetupPath);
            }
            return returnValue;
        }
    }
}