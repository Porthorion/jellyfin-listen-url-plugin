using System;
using Microsoft.AspNetCore.Mvc;

namespace Jellyfin.Plugin.Template;

/// <summary>
/// Redirects listen URLs to the standard Jellyfin download endpoint.
/// </summary>
[ApiController]
[Route("listen")]
public sealed class ListenController : ControllerBase
{
    /// <summary>
    /// Redirects /listen/{id} to the built-in download route.
    /// </summary>
    /// <param name="id">Item identifier.</param>
    /// <returns>A redirect result.</returns>
    [HttpGet("{id}")]
    public IActionResult Listen(Guid id)
    {
        return Redirect($"/Items/{id}/Download");
    }
}
