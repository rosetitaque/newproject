  public IReadOnlyList<ReleaseNotes> Parse(string content)
    {
        if (content == null)
        {
            throw new ArgumentNullException(nameof(content));
        }

        var lines = content.SplitLines();
        if (lines.Length > 0)
        {
            var line = lines[0].Trim();

            if (line.StartsWith("#", StringComparison.OrdinalIgnoreCase))
            {
                return ParseComplexFormat(lines);
            }

            if (line.StartsWith("*", StringComparison.OrdinalIgnoreCase))
            {
                return ParseSimpleFormat(lines);
            }
        } public static bool TryParse(string version,
        out SemVersion semVersion)
    {
        semVersion = Zero;

        if (string.IsNullOrEmpty(version))
        {
            return false;
        }

        var match = SemVerRegex.Match(version);
        if (!match.Success)
        {
            return false;
        }
