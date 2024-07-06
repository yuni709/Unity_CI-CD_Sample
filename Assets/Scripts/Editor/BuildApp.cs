using UnityEditor;

public static class BuildApp 
{
    [MenuItem("Build/BuildApp")]
    public static void Build()
    {
        // Windows 64-bit platform build
        BuildPipeline.BuildPlayer(
            new string[] { "Assets/Scenes/SampleScene.unity" },
            "D:\\UnityPackages\\Unity_CI_CD_Sampe\\SampleApp.exe",
            BuildTarget.StandaloneWindows64,
            BuildOptions.None
        );
    }
}
