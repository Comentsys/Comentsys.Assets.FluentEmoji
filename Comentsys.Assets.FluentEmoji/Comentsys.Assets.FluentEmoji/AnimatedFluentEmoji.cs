namespace Comentsys.Assets.FluentEmoji;

/// <summary>
/// Emoji designed by Microsoft - an animated collection of familiar, friendly, and modern emoji. License: MIT License
/// </summary>
public class AnimatedFluentEmoji : ImageBase<AnimatedFluentEmoji>
{
    private const int width = 256;
    private const int height = 256;

    /// <summary>
    /// Link
    /// </summary>
    /// <param name="type">Fluent Emoji Type</param>
    /// <returns>Fluent Emoji Image Link</returns>
    private static Uri? Link(FluentEmojiType type) =>
        FluentEmojiMeta.Data[type]?.AnimatedEmoji;

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

    /// <summary>
    /// List Animated Emoji
    /// </summary>
    /// <returns>Fluent Emoji Types</returns>
    public FluentEmojiType[] ListAnimatedEmoji() =>
        [.. FluentEmojiMeta.Data.Where(x => x.Value.HasAnimatedEmoji).Select(x => x.Key)];
}
