namespace Script.Install.Creator.Library.Module.Commands.CreatePackage
{
    public interface ICreatePackageCommandProvider
    {
        int CreatePackage(string sourceSetupPath, string packagesFolder);
    }
}
