namespace Comentsys.Assets.FluentEmoji.SourceGenerator;

/// <summary>
/// Emoji Enum Generator
/// </summary>
[Generator]
public class EmojiEnumGenerator : ISourceGenerator
{
    /// <summary>
    /// Split Capital
    /// </summary>
    /// <param name="source">Source Text</param>
    /// <returns>Target List</returns>
    private IEnumerable<string> SplitCapital(string source)
    {
        Regex regex = new(@"\p{Lu}\p{Ll}*");
        foreach (Match match in regex.Matches(source))
        {
            yield return match.Value;
        }
    }

    /// <summary>
    /// Execute
    /// </summary>
    /// <param name="context">Generator Execution Context</param>
    public void Execute(GeneratorExecutionContext context)
    {
        if (!context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.projectdir", out var projectDir))
        {
            return; // Should never reach here
        }
        // Get directory where svg files are
        var resourceDirectory = Path.Combine(projectDir, "Resources", "Flat");
        var svgFiles = Directory.EnumerateFiles(resourceDirectory, "*.svg").ToList();
        var builder = new StringBuilder();
        builder.AppendLine("// Auto-generated code");
        builder.AppendLine();
        builder.AppendLine("namespace Comentsys.Assets.FluentEmoji;");
        builder.AppendLine();
        builder.AppendLine("/// <summary>");
        builder.AppendLine("/// Fluent Emoji Type");
        builder.AppendLine("/// Emoji designed by Microsoft - a collection of familiar, friendly, and modern emoji. License: MIT License");
        builder.AppendLine("/// </summary>");
        builder.AppendLine("public enum FluentEmojiType");
        builder.AppendLine("{");
        builder.AppendLine("\t/// <summary>");
        builder.AppendLine($"\t/// None");
        builder.AppendLine("\t/// </summary>");
        builder.AppendLine($"\tNone,");
        foreach (var svgFile in svgFiles)
        {
            builder.AppendLine("\t/// <summary>");
            builder.AppendLine($"\t/// {string.Join(" ", SplitCapital(Path.GetFileNameWithoutExtension(svgFile)))}");
            builder.AppendLine("\t/// </summary>");
            builder.AppendLine($"\t{Path.GetFileNameWithoutExtension(svgFile)},");
        }
        builder.AppendLine("}");
        builder.AppendLine();
        context.AddSource("Comentsys.Assets.FluentEmoji.FluentEmojiType.generated.cs", builder.ToString());
    }

    /// <summary>
    /// Initialise
    /// </summary>
    /// <param name="context">Initialisation Context</param>
    public void Initialize(GeneratorInitializationContext context)
    {
        // No init required for this source generator
    }
}
