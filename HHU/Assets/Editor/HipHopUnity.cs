using UnityEngine;
using UnityEditor;
using System.Collections;

public class HipHopUnity : EditorWindow
{
    public Object HIP;
    public Object HOP;

    [MenuItem("Window/HHU Toolset")]

    public static void ShowWindow ()
    {
        GetWindow<HipHopUnity>("HipHopUnity");
    }

    void OnGUI()
    {
       EditorGUILayout.ObjectField(HIP, typeof(Object), true);
       EditorGUILayout.ObjectField(HOP, typeof(Object), true);
    }
}
