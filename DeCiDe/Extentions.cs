using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decide;

static class Extentions
{

    public static bool Check(this string value) => value.Any(el => char.IsLetterOrDigit(el));

    /// <summary>
    /// Checks char elements in string.
    /// Example: "Hello, Wolrd!".Check(",!") => true
    /// </summary>
    /// <param name="value"></param>
    /// <param name="includes"></param>
    /// <param name="isFound"></param>
    /// <returns>bool value = if string have char includes...</returns>
    public static bool Check(this string value, string includes, bool isFound = true)
    {
        foreach (char item in includes) if (value.Contains(item)) return isFound;
        return !isFound;
    }

    public static bool Includes(this string value, string[] includes, bool isFound = true)
    {
        foreach (string item in includes) if (value.Contains(item)) return isFound;
        return !isFound;
    }

    public static bool Includes(this string value, int[] includes, bool isFound = true)
    {
        foreach (int item in includes) if (value.Contains(item.ToString())) return isFound;
        return !isFound;
    }


}
