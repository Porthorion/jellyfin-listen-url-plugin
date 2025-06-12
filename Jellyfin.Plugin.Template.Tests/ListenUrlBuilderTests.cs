using System;
using Jellyfin.Plugin.ListenUrl;
using MediaBrowser.Controller.Entities.Audio;
using MediaBrowser.Controller.Entities;
using Xunit;

namespace Jellyfin.Plugin.ListenUrl.Tests;

public class ListenUrlBuilderTests
{
    [Fact]
    public void AudioItems_ReturnListenUrl()
    {
        var item = new Audio { Id = Guid.NewGuid() };
        var builder = new ListenUrlBuilder();

        var url = builder.GetUrl(item);

        Assert.Equal($"/listen/{item.Id}", url);
    }

    [Fact]
    public void VideoItems_ReturnDownloadUrl()
    {
        var item = new Video { Id = Guid.NewGuid() };
        var builder = new ListenUrlBuilder();

        var url = builder.GetUrl(item);

        Assert.Equal($"/Items/{item.Id}/Download", url);
    }
}
