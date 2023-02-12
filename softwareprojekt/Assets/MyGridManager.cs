using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGridManager : MonoBehaviour
{
    public int pixelsperunit = 1;
    void Start()
    {
        GameObject referenceTile =(GameObject)Instantiate((GameObject)Instantiate(Resources.Load("FieldPrefab")), transform);
        for(int x=0;x<9;x++) for(int y=0;y<9;y++){
            GameObject tile =(GameObject)Instantiate(referenceTile, transform);
            tile.transform.position = new Vector2(128/pixelsperunit*x+260, 128/pixelsperunit*y+40);
            //tile.transform.localScale = new Vector3(50,50,50);
            //tile.GetComponent<SpriteRenderer>().sprite = squaretexture;
        }
        Destroy(GameObject.Find("FieldPrefab(Clone)"));
    }
}
