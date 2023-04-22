using Cake.Common.Tools.DotNet;
using Cake.Frosting;

namespace Build;

using Cake.Common.Tools.DotNet.Build;

[TaskName("Build")]
[IsDependentOn(typeof(CleanTask))]
public sealed class BuildTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.DotNetBuild("../../../xUnit.Gwt.sln", new DotNetBuildSettings
        {
            NoRestore = false,
            Configuration = context.MsBuildConfiguration
        });
    }
}