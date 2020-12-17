using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ExportAssetBuondle : MonoBehaviour {
    [MenuItem("Window/Buile AssetBuondle")]
   static void CreateAssetBunldeMain()
    {
        BuildPipeline.BuildAssetBundles("Assets/AssetBunlde", BuildAssetBundleOptions.UncompressedAssetBundle, BuildTarget.StandaloneWindows64);
    }
}
