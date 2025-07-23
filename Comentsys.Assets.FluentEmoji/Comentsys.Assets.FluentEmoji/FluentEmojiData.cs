namespace Comentsys.Assets.FluentEmoji;

/// <summary>
/// Fluent Emoji Data
/// Emoji designed by Microsoft - a collection of familiar, friendly, and modern emoji. License: MIT License
/// </summary>
public class FluentEmojiData
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="type">Fluent Emoji Type</param>
    /// <param name="name">Common Locale Data Repository Name</param>
    /// <param name="glyph">Glyph</param>
    /// <param name="unicode">Unicode</param>
    /// <param name="group">Group</param>
    /// <param name="keywords">Keywords</param>
    /// <param name="emoticons">Emoticons</param>
    /// <param name="imageEmoji">Image Emoji</param>
    /// <param name="animatedEmoji">Animated Emoji</param>
    public FluentEmojiData(FluentEmojiType type, string? name, string? glyph, string? unicode, string? group, string[]? keywords, string[]? emoticons, string? imageEmoji, string? animatedEmoji = null) =>
        (Type, Name, Glyph, Unicode, Group, Keywords, Emoticons, ImageEmoji, AnimatedEmoji) = 
        (type, name, glyph, unicode, group, keywords, emoticons, 
        imageEmoji != null ? new Uri(imageEmoji) : null, 
        animatedEmoji != null ? new Uri(animatedEmoji) : null);

    /// <summary>
    /// Fluent Emoji Type
    /// </summary>
    public FluentEmojiType Type { get; set; }

    /// <summary>
    /// Common Locale Data Repository Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Glyph
    /// </summary>
    public string? Glyph { get; set; }

    /// <summary>
    /// Unicode
    /// </summary>
    public string? Unicode { get; set; }

    /// <summary>
    /// Group
    /// </summary>
    public string? Group { get; set; }

    /// <summary>
    /// Keywords
    /// </summary>
    public string[]? Keywords { get; set; }

    /// <summary>
    /// Emoticons
    /// </summary>
    public string[]? Emoticons { get; set; }

    /// <summary>
    /// Image Emoji Link
    /// </summary>
    public Uri? ImageEmoji { get; set; }

    /// <summary>
    /// Animated Emoji Link
    /// </summary>
    public Uri? AnimatedEmoji { get; set; }

    /// <summary>
    /// Has Animated Emoji?
    /// </summary>
    public bool HasAnimatedEmoji => 
        AnimatedEmoji is not null;
}
