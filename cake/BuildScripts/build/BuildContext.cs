using Cake.Common;
using Cake.Core;
using Cake.Frosting;

public sealed class BuildContext : FrostingContext
{
    public string MsBuildConfiguration { get; set; }

    public BuildContext(ICakeContext context) : base(context)
    {
        MsBuildConfiguration = context.Arguments().ContainsKey("Configuration") ? 
            Arguments.GetArgument("Configuration") : context.Argument("configuration", "Release");
    }
}