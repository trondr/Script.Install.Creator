namespace Script.Install.Creator.Library.Infrastructure
{
    public interface ITypeMapper
    {
        T Map<T>(object source);
    }
}
