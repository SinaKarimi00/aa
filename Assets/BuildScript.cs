using UnityEditor;

namespace DefaultNamespace
{
    public class BuildScript
    {
#if UNITY_EDITOR

        public static void BuildAndroid()
        {
            string[] scenes = { "Assets/Scene1.unity", "Assets/Scene2.unity" }; // Add your scene paths here
            string outputPath = "Builds/AndroidBuild.apk"; // Specify the output path for the APK

            BuildPipeline.BuildPlayer(scenes, outputPath, BuildTarget.Android, BuildOptions.None);
        }
#endif
    }
}