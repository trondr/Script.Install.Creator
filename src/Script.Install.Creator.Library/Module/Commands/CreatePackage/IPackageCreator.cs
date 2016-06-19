namespace Script.Install.Creator.Library.Module.Commands.CreatePackage
{
    public interface IPackageCreator
    {
        bool CanHandle(string sourcePath);

        void CreatePackage(string sourcePath);
    }
}