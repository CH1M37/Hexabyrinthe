using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GridHex))]
public class GridEditor : Editor {

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GridHex grid = (GridHex)target;

        int size = grid.gridSize;
        float scale = grid.gridScale;

        if(GUILayout.Button("Create Grid"))
        {
            grid.ResetGrid();
            grid.CreateGrid(size, scale);
        }
    }
}
