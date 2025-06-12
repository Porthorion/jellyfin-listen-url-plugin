using MediaBrowser.Controller.Entities;

namespace Jellyfin.Plugin.Template;

/// <summary>
/// Service that builds download URLs for items.
/// </summary>
public interface IDownloadUrlBuilder
{
    /// <summary>
    /// Gets the download URL for an item.
    /// </summary>
    /// <param name="item">The library item.</param>
    /// <returns>The download URL.</returns>
    string GetUrl(BaseItem item);
}
