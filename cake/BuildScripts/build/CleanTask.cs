using Cake.Frosting;

namespace Build;

using Cake.Common.IO;

[TaskName("Clean")]
public sealed class CleanTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.CleanDirectory($"../../../src/xUnit.Gwt/bin/{context.MsBuildConfiguration}");
        context.CleanDirectory($"../../../tests/xUnit.Gwt/bin/{context.MsBuildConfiguration}");
    }
}