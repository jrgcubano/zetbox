
namespace Kistl.API.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Text;

    using Kistl.API.Configuration;

    using NUnit.Framework;

    [TestFixture]
    public class ConfigurationTests
        : AbstractApiTestFixture
    {
        readonly static string ConfigFile = "Kistl.API.Tests.xml";

        private void CheckConfig(KistlConfig cfg)
        {
            Assert.That(cfg.ConfigName, Is.Not.Empty, "ConfigName");
            Assert.That(cfg.SourceFileLocation, Is.Not.Empty, "SourceFileLocation");

            Assert.That(cfg.Client, Is.Not.Null, "Client");

            Assert.That(cfg.Server, Is.Not.Null, "Server");
            Assert.That(cfg.Server.ConnectionString, Is.Not.Empty, "ConnectionString");
            Assert.That(cfg.Server.DatabaseProvider, Is.Not.Empty, "DatabaseProvider");
            Assert.That(cfg.Server.DocumentStore, Is.Not.Empty, "DocumentStore");
        }

        [Test]
        public void DefaultLoading()
        {
            var defaultDest = Path.Combine("Configs", "DefaultConfig.xml");
            if (!File.Exists(defaultDest))
            {
                File.Copy("TestConfig.xml", defaultDest);
            }
            var config = KistlConfig.FromFile(String.Empty, "DefaultConfig.xml");

            Assert.That(config, Is.Not.Null, "Configuration");
            Assert.That(config.ConfigFilePath, Is.Not.Empty, "ConfigFilePath");
            Assert.That(config.ConfigName, Is.Not.Empty, "ConfigName");
        }

        [Test]
        public void LoadFile()
        {
            var config = KistlConfig.FromFile("TestConfig.xml", "DoesNotExist.xml");

            Assert.That(config, Is.Not.Null, "Configuration");
            Assert.That(config.ConfigFilePath, Is.EqualTo("TestConfig.xml"), "ConfigFilePath");
            Assert.That(config.ConfigName, Is.Not.Empty, "ConfigName");
        }

        [Test]
        public void FromStream()
        {
            using (FileStream s = File.OpenRead(KistlConfig.GetDefaultConfigName(ConfigFile)))
            {
                KistlConfig cfg = KistlConfig.FromStream(s);
                Assert.That(cfg.ConfigFilePath, Is.Null);
                CheckConfig(cfg);
            }
        }

        [Test]
        public void FromTextReader()
        {
            using (FileStream s = File.OpenRead(KistlConfig.GetDefaultConfigName(ConfigFile)))
            {
                TextReader rd = new StreamReader(s);
                KistlConfig cfg = KistlConfig.FromStream(rd);
                Assert.That(cfg.ConfigFilePath, Is.Null);
                CheckConfig(cfg);
            }
        }

        [Test]
        public void ToFile()
        {
            string filename = @"testconfig_to_see_if_saving_works.xml";
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            var config = KistlConfig.FromFile(String.Empty, "DefaultConfig.xml");
            config.ToFile(filename);
            Assert.That(File.Exists(filename), Is.True);
            Assert.That(new FileInfo(filename).Length, Is.GreaterThan(0));
            File.Delete(filename);
        }

        [Test]
        public void ToStream()
        {
            MemoryStream ms = new MemoryStream();
            var config = new KistlConfig();
            config.ToStream(ms);
            Assert.That(ms.Length, Is.GreaterThan(0));
        }

        [Test]
        public void ConfigurationExceptionWithMessage()
        {
            var message = "message";
            var ex = new ConfigurationException(message);
            Assert.That(ex.Message, Is.EqualTo(message));
        }

        [Test]
        public void ConfigurationExceptionWithoutMessage()
        {
            var ex = new ConfigurationException();
            Assert.That(ex.Message, Is.Not.Empty);
        }
    }
}