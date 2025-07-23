namespace Comentsys.Assets.FluentEmoji;

/// <summary>
/// Emoji designed by Microsoft - a collection of familiar, friendly, and modern emoji. License: MIT License
/// </summary>
public class ImageFluentEmoji : ImageBase<ImageFluentEmoji>
{
    private const int width = 256;
    private const int height = 256;

    /// <summary>
    /// Link
    /// </summary>
    /// <param name="type">Fluent Emoji Type</param>
    /// <returns>Fluent Emoji Image Uri</returns>
    private static Uri? Link(FluentEmojiType type) =>
        FluentEmojiMeta.Data[type]?.ImageEmoji;

    /// <summary>
    /// Get Image Resource
    /// </summary>
    /// <param name="client">Http Client</param>
    /// <param name="type">Fluent Emoji Type</param>
    /// <returns>Image Resource</returns>
    public static async Task<ImageResource> Get(HttpClient client, FluentEmojiType type) =>
        new(await AsStream(client, Link(type)) ?? new MemoryStream(), height, width);

    /// <summary>
    /// Get Image Resource
    /// </summary>
    /// <param name="type">Fluent Emoji Type</param>
    /// <returns>Image Resource</returns>
    public static Task<ImageResource> Get(FluentEmojiType type) =>
        Get(new HttpClient(), type);
}
