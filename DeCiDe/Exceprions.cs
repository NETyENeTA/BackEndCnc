using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decide;

public class ErrorWithName : Exception
{
    public ErrorWithName(string message) : base("Error in the name!" + message) { }
}

public class ConsoleReadLineError : Exception
{
    public ConsoleReadLineError(string message) : base("The console was closed, maybe it was a error or mistake" + message) { }
}

public class IntParseError : Exception
{
    public IntParseError(string message) : base("Please type a NUMBER, not string" + message) { }
}

// And here it would have been possible to describe the remaining exceptions, but alas, the terms of reference do not require this)
