using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MapEditor 
{
#if UNITY_EDITOR
    // % Ctrl / # Shift / & Alt
    [MenuItem("Tools/Generate Map %#m")]
    private static void GenerateMap()
    {
        if (EditorUtility.DisplayDialog("Hello World", "Create?", "Create", "Cancel")) ;
        {
            GameObject go = GameObject.Find("Map");
            if (go == null)
                Debug.Log("Map GameObject Not Found");

            //Util.FindChild<TileMap>(go, "Tilemap_Collision", true);

            new GameObject("Hello World");
        }
    }
#endif
}
