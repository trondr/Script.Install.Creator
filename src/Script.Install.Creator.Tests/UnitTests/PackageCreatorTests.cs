using Common.Logging;
using Common.Logging.Simple;
using NUnit.Framework;
using Script.Install.Creator.Infrastructure;
using Script.Install.Creator.Library.Module.Commands.CreatePackage;

namespace Script.Install.Creator.Tests.UnitTests
{
    [TestFixture(Category = "UnitTests")]
    public class PackageCreatorTests
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

        [Test]
        public void MsiPackageCreator_CanHandle_LowercaseMsiExtension_True()
        {
            
            using(var testBooStrapper = new BootStrapper())
            {
                var target = testBooStrapper.Container.Resolve<IMsiPackageCreator>();
                var expected = true;
                string testPath = @"c:\temp\some.msi";
                var actual = target.CanHandle(testPath);
                Assert.AreEqual(expected, actual);
            }
        }

        [Test]
        public void MsiPackageCreator_CanHandle_UppercaseMsiExtension_True()
        {
            
            using(var testBooStrapper = new BootStrapper())
            {
                var target = testBooStrapper.Container.Resolve<IMsiPackageCreator>();
                var expected = true;
                string testPath = @"c:\temp\some.MSi";
                var actual = target.CanHandle(testPath);
                Assert.AreEqual(expected, actual);
            }
        }

        [Test]
        public void MsuPackageCreator_CanHandle_LowercaseMsuExtension_True()
        {
            
            using(var testBooStrapper = new BootStrapper())
            {
                var target = testBooStrapper.Container.Resolve<IMsuPackageCreator>();
                var expected = true;
                string testPath = @"c:\temp\some.msu";
                var actual = target.CanHandle(testPath);
                Assert.AreEqual(expected, actual);
            }
        }

        [Test]
        public void MsuPackageCreator_CanHandle_UppercaseMsuExtension_True()
        {
            
            using(var testBooStrapper = new BootStrapper())
            {
                var target = testBooStrapper.Container.Resolve<IMsuPackageCreator>();
                var expected = true;
                string testPath = @"c:\temp\some.Msu";
                var actual = target.CanHandle(testPath);
                Assert.AreEqual(expected, actual);
            }
        }

        [Test]
        public void ExePackageCreator_CanHandle_LowercaseExeExtension_True()
        {
            
            using(var testBooStrapper = new BootStrapper())
            {
                var target = testBooStrapper.Container.Resolve<IExePackageCreator>();
                var expected = true;
                string testPath = @"c:\temp\some.exe";
                var actual = target.CanHandle(testPath);
                Assert.AreEqual(expected, actual);
            }
        }

        [Test]
        public void ExePackageCreator_CanHandle_UppercaseExeExtension_True()
        {
            
            using(var testBooStrapper = new BootStrapper())
            {
                var target = testBooStrapper.Container.Resolve<IExePackageCreator>();
                var expected = true;
                string testPath = @"c:\temp\some.Exe";
                var actual = target.CanHandle(testPath);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}