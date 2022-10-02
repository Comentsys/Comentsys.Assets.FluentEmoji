using Microsoft.CodeAnalysis;
using System.Text;

namespace Comentsys.Assets.FluentEmoji.SourceGenerator;

[Generator]
public class EmojiEnumGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
        if (!context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.projectdir", out var projectDir))
        {
            // Should never reach here
            return;
        }

        // Get directory where svg files are
        var resourceDirectory = Path.Combine(projectDir, "Resources", "Flat");

        var svgFiles = Directory
            .EnumerateFiles(resourceDirectory, "*.svg")
            .ToList();

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

        foreach (var svgFile in svgFiles)
        {
            builder.AppendLine("    /// <summary>");
            builder.AppendLine($"    /// Icon type {Path.GetFileNameWithoutExtension(svgFile)}");
            builder.AppendLine("    /// </summary>");

            builder.AppendLine($"    {Path.GetFileNameWithoutExtension(svgFile)},");
        }

        builder.AppendLine("}");
        builder.AppendLine();

        context.AddSource("Comentsys.Assets.FluentEmoji.FluentEmojiType.generated.cs", builder.ToString());

    }

    public void Initialize(GeneratorInitializationContext context)
    {
        // No init required for this source generator
    }
}
