# Jellyfin Listen URL Plugin

This plugin is currently under active development. Its goal is to change the URL copied when using the **Copy Stream** button in Jellyfin.

Instead of generating a link of the form:

```
/items/<item_id>/download?api_key=<api_key>
```

it will produce a simpler URL:

```
/listen/<item_id>
```

This behaviour requires that Jellyfin is accessed through a reverse proxy which handles the `/listen` endpoint.

The plugin is designed with audio libraries in mind. It may not work correctly for video content until further work is done to handle those cases.


