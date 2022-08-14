using System;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEditor;


public class ModBuilder : MonoBehaviour
{
    [MenuItem("Mods/Build Mod")]
    static void BuildMod()
    {
        AssetBundleBuild[] buildMap = new AssetBundleBuild[1];

        var assetNames = AssetDatabase.GetAllAssetPaths().Where(s => s.StartsWith("Assets/") && !s.Contains("Editor") && !s.Contains(".meta") && !s.Contains(".unity") && !s.Contains("Scenes")).ToArray();
        var addressableNames = new string[assetNames.Length];

        for (var i = 0; i < assetNames.Length; i++)
        {
            addressableNames[i] = assetNames[i].Replace("Assets/", "");
        }

        string modName = Application.productName;

        buildMap[0].assetBundleName = $"{modName}.mod";
        buildMap[0].assetNames = assetNames;
        buildMap[0].addressableNames = addressableNames;

        string modsFolderName = "Mods";
        Directory.CreateDirectory(modsFolderName);

        BuildPipeline.BuildAssetBundles(modsFolderName, buildMap, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }
}
