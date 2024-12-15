using UnrealBuildTool;
using System.Collections.Generic;

public class Project2D : TargetRules
{
    public Project2D(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V2;

        // Force Visual Studio 2022 (MSVC 14.34.x)
        if (Target.Platform == UnrealTargetPlatform.Win64)
        {
            WindowsPlatform.Compiler = WindowsCompiler.VisualStudio2022;
        }
    }
}