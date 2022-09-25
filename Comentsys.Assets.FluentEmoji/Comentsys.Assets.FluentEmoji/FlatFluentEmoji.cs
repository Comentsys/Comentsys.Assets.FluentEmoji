namespace Comentsys.Assets.FluentEmoji;

/// <summary>
/// Emoji designed by Microsoft - a collection of familiar, friendly, and modern emoji. License: MIT License
/// </summary>
public class FlatFluentEmoji : AssetBase<FlatFluentEmoji>
{
    private const int width = 32;
    private const int height = 32;
    private const string folder = "Flat";
    private const string root = "Comentsys.Assets.FluentEmoji.Resources";

    /// <summary>
    /// Path
    /// </summary>
    /// <param name="type">Fluent Emoji Type</param>
    /// <returns>Fluent Emoji Path</returns>
    private static string Path(FluentEmojiType type) =>
        $"{folder}.{Enum.GetName(typeof(FluentEmojiType), type) ?? string.Empty}";

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="type">Fluent Emoji Type</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(FluentEmojiType type) =>
        new(AsStream(root, Path(type)) ?? new MemoryStream(), height, width);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="type">Fluent Emoji Type</param>
    /// <param name="source">Source Colour</param>
    /// <param name="target">Target Colour</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(FluentEmojiType type, Color? source, Color? target) =>
        new(AsStream(root, Path(type), source, target) ?? new MemoryStream(), height, width);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="type">Fluent Emoji Type</param>
    /// <param name="sources">Source Colours</param>
    /// <param name="targets">Target Colours</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(FluentEmojiType type, Color[]? sources, Color[]? targets) =>
        new(AsStream(root, Path(type), sources, targets) ?? new MemoryStream(), height, width);
}