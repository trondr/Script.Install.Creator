namespace Script.Install.Creator.Library.Infrastructure
{
    public interface ILoggingConfiguration
    {
        string LogDirectoryPath { get; set; }
        string LogFileName { get; set; }
    }
}
