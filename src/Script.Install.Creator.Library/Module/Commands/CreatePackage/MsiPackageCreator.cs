using System;
using System.IO;

namespace Script.Install.Creator.Library.Module.Commands.CreatePackage
{
    public class MsiPackageCreator : IMsiPackageCreator
    {
        public bool CanHandle(string sourcePath)
        {
            var fileExtension = Path.GetExtension(sourcePath);
            if(!string.IsNullOrEmpty(fileExtension) && fileExtension.ToLower() == ".msi")
            {
                return true;
            }
            return false;
        }

        public void CreatePackage(string sourcePath)
        {
            ValidateSourcePath(sourcePath);
            throw new NotImplementedException();
        }

        private void ValidateSourcePath(string sourcePath)
        {
            var canHandle = CanHandle(sourcePath);
            if (!canHandle) throw new ScriptInstallCreatorException(this.GetType().Name + " cannot create package from source path: " + sourcePath);
        }
    }
}