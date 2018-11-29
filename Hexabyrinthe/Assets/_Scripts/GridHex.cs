using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridHex : MonoBehaviour {

    [SerializeField]
    private GameObject tilePrefab;

    public int gridSize;
    public float gridScale;

    #region Grid Creation

    public void ResetGrid()
    {
        GameObject[] tilesArray = GameObject.FindGameObjectsWithTag("tile");

        foreach (GameObject tileToDestroy in tilesArray)
        {
            DestroyImmediate(tileToDestroy);
        }

    }

    public void CreateGrid(int n, float scale)
    {
        for(int i=0; i<n;i++)
        {
            //CreateGrid
            for(int j=0; j<n; j++)
            {
                GameObject tile = Instantiate(tilePrefab);
                tile.transform.SetParent(this.transform, false);
                tile.transform.position = Vector3.zero;
                tile.transform.localScale = new Vector3(scale, tile.transform.localScale.y, scale);

                tile.transform.position = new Vector3(scale * i, 0f, scale * j);

                //Color
                if ((i % 2 == 0 && j % 2 == 0) || (i % 2 == 1 && j % 2 == 1))
                {
                    Renderer rend = tile.GetComponent<Renderer>();
                    rend.material.color = Color.black;
                }
            }
        }
    }
    #endregion

}
