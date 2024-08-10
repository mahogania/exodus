using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Collection.APIs.Common.Attributes;

public class RegularExpressionEnumerable : RegularExpressionAttribute
{
    public RegularExpressionEnumerable(string pattern)
        : base(pattern)
    {
    }

    public override bool IsValid(object? value)
    {
        if (value == null)
            return true;

        if (value is not IEnumerable<string>)
            return false;

        var values = value as IEnumerable<string> ?? [];

        foreach (var val in values)
            if (!Regex.IsMatch(val, Pattern))
                return false;

        return true;
    }
}
