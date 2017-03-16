using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TileBuilder))]
public class TileBuilderEditor : Editor
{

    public override void OnInspectorGUI()
    {
        TileBuilder myyTileBuilder = (TileBuilder) target;

        DrawDefaultInspector();
        if(GUILayout.Button("Build Tiles"))
        {
            myyTileBuilder.BuildTiles();
        }

    }

}
