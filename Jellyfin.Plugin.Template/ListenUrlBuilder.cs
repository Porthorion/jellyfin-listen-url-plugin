using System;
using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Entities.Audio;

namespace Jellyfin.Plugin.ListenUrl;

/// <summary>
/// Implementation of <see cref="IDownloadUrlBuilder"/> that returns a custom
/// URL for audio items.
/// </summary>
public sealed class ListenUrlBuilder : IDownloadUrlBuilder
{
    /// <inheritdoc />
    public string GetUrl(BaseItem item)
    {
        if (item is Audio)
        {
            return $"/listen/{item.Id}";
        }

        return $"/Items/{item.Id}/Download";
    }
}
