using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class AssetBundle :Editor
{
    [MenuItem("Custom Editor/Build AssetBundles")]

    static void BuildAsset()
    {
        BuildPipeline.BuildAssetBundles("Assets/StreamingAssets", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);

    }
}
