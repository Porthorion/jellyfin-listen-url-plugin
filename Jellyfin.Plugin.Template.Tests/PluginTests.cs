using System;
using System.IO;
using Jellyfin.Plugin.Template;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Model.Serialization;
using Xunit;

namespace Jellyfin.Plugin.Template.Tests;

public class PluginTests
{
    private class StubApplicationPaths : IApplicationPaths
    {
        public string ProgramDataPath => string.Empty;
        public string WebPath => string.Empty;
        public string ProgramSystemPath => string.Empty;
        public string DataPath => string.Empty;
        public string ImageCachePath => string.Empty;
        public string PluginsPath => string.Empty;
        public string PluginConfigurationsPath => string.Empty;
        public string LogDirectoryPath => string.Empty;
        public string ConfigurationDirectoryPath => string.Empty;
        public string SystemConfigurationFilePath => string.Empty;
        public string CachePath => string.Empty;
        public string TempDirectory => string.Empty;
        public string VirtualDataPath => string.Empty;
    }

    private class StubXmlSerializer : IXmlSerializer
    {
        public object DeserializeFromStream(Type type, Stream stream) => throw new NotImplementedException();
        public void SerializeToStream(object obj, Stream stream) => throw new NotImplementedException();
        public void SerializeToFile(object obj, string file) => throw new NotImplementedException();
        public object DeserializeFromFile(Type type, string file) => throw new NotImplementedException();
        public object DeserializeFromBytes(Type type, byte[] buffer) => throw new NotImplementedException();
    }

    [Fact]
    public void GetPages_ReturnsSingleConfigurationPage()
    {
        var plugin = new Plugin(new StubApplicationPaths(), new StubXmlSerializer());

        var pages = plugin.GetPages();

        var page = Assert.Single(pages);
        Assert.EndsWith("Configuration.configPage.html", page.EmbeddedResourcePath);
    }
}

