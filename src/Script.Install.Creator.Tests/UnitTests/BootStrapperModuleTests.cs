using Common.Logging.Simple;
using NUnit.Framework;
using Script.Install.Creator.Library.Infrastructure;
using Script.Install.Creator.Library.Module.Commands.CreatePackage;
using Script.Install.Creator.Tests.Common;
using LogLevel = Common.Logging.LogLevel;

namespace Script.Install.Creator.Tests.UnitTests
{
    [TestFixture(Category = "UnitTests")]
    public class BootStrapperModuleTests
    {
        private ConsoleOutLogger _logger;

        [SetUp]
        public void SetUp()
        {
            _logger = new ConsoleOutLogger(this.GetType().Name, LogLevel.All, true, false, false, "yyyy-MM-dd hh:mm:ss");
        }

        [TearDown]
        public void TearDown()
        {

        }

        [Test, RequiresSTA]
        public void PackageCreatorRegistrationTest()
        {
            BootStrapperTestsHelper.CheckThatNumberOfResolvedServicesAre<IPackageCreator>(3);            
            BootStrapperTestsHelper.CheckThatResolvedServiceHasSingletonLifeCycle<IPackageCreator>();
        }
        
    }
}