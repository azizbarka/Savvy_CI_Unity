using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Builder
{

    static string[] scenes = new string[]
    {
        "Assets/Scenes/Level1.unity",
        "Assets/Scenes/Level2.unity",
        "Assets/Scenes/Level3.unity"
    };

    static void BuildAndroid()
    {
        BuildPipeline.BuildPlayer(scenes, @".\Builds\Android\Game.apk", BuildTarget.Android,BuildOptions.None);
    }
    static void BuildWindows()
    {
        BuildPipeline.BuildPlayer(scenes, @".\Builds\Game.exe", BuildTarget.StandaloneWindows64, BuildOptions.None);
    }
    static void BuildIOS()
    {
        BuildPipeline.BuildPlayer(scenes, @".\Builds\IOS\", BuildTarget.iOS, BuildOptions.None);
    }
}
