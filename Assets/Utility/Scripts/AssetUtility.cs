#if UNITY_EDITOR

using System.IO;
using UnityEditor;
using UnityEngine;

namespace Jawa.Utility
{
    public static class AssetUtility
    {
        public static TAsset CreateAsset<TAsset>() where TAsset : ScriptableObject
        {
            var asset = ScriptableObject.CreateInstance<TAsset>();

            AssetDatabase.CreateAsset(asset, GetPathForNewAsset(asset));
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            return asset;
        }

        private static string GetPathForNewAsset(object asset)
        {
            var path = AssetDatabase.GetAssetPath(Selection.activeObject);

            if (path == string.Empty)
            {
                path = "Assets";
            }
            else if (Path.GetExtension(path) != string.Empty)
            {
                path = path.Replace(Path.GetFileName(path), string.Empty);
            }

            path = AssetDatabase.GenerateUniqueAssetPath(path + "/" + asset.GetType().Name + ".asset");

            return path;
        }
    }
}

#endif
