using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Builder
{
    private const string BUILDS_FOLDER= "D:\\SAVVY CLI";

    static string[] scenes = new string[]
    {
        "Assets/Scenes/Level1.unity",
        "Assets/Scenes/Level2.unity",
        "Assets/Scenes/Level3.unity"
    };


    static void BuildAndroid()
    {
        BuildPipeline.BuildPlayer(scenes, $@"C:\Users\Abdulaziz\OneDrive\Desktop\JenkinsFiles\Android\FILE.Apk", BuildTarget.Android,BuildOptions.None);
    }
    static void BuildWindows()
    {
        BuildPipeline.BuildPlayer(scenes, @"C:\Users\Abdulaziz\OneDrive\Desktop\JenkinsFiles\Windows\Game.exe", BuildTarget.StandaloneWindows64, BuildOptions.None);

    }
}
