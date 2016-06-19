using System;
using Common.Logging;

namespace Script.Install.Creator.Infrastructure
{
    public interface ILogFactory
    {
        ILog GetLogger(Type type);
    }
}