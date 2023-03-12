using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGridManager : MonoBehaviour
{
    public int pixelsperunit; //Muss 3 sein
    public Sprite SpriteRenderer1; //Gras
    public Sprite SpriteRenderer2; //Gebirge
    public GameObject referenceTile;
    [SerializeField] GameObject level1;
    LevelProperties levelprops;
    void Awake(){
        levelprops=level1.GetComponent<LevelProperties>();
    }
    void Start()
    {
        //for(int i=0;i<9;i++) for(int j=0;j<9;j++) Debug.Log(levelprops.map[i,j]);
        //GameObject referenceTile =(GameObject)Instantiate((GameObject)Instantiate(Resources.Load("FieldPrefab")), transform);
        for(int x=0;x<9;x++) for(int y=0;y<9;y++){
            GameObject tile =(GameObject)Instantiate(referenceTile, transform);
            tile.transform.position = new Vector2(128/pixelsperunit*x+260, 128/pixelsperunit*y+40);
            //tile.transform.localScale = new Vector3(50,50,50);
            if(levelprops.map[x,y]==1) tile.GetComponent<SpriteRenderer>().sprite = SpriteRenderer2; //(x+y)%2==1
            else tile.GetComponent<SpriteRenderer>().sprite = SpriteRenderer1;
        }
        Destroy(GameObject.Find("FieldPrefab(Clone)"));
    }
}
