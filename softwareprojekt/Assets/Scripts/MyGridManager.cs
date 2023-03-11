using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGridManager : MonoBehaviour
{
    public int pixelsperunit; //Muss 3 sein
    public Sprite SpriteRenderer1; //Gras
    public Sprite SpriteRenderer2; //Gebirge
    public GameObject referenceTile;
    public int[,] map ={                                    //1-gras, 0-gebirge, 2-...
                        {1,0,1,1,1,1,1,1,1},
                        {1,1,1,1,1,1,1,1,1},
                        {1,1,1,1,1,0,1,1,1},
                        {1,1,1,0,1,1,1,1,1},
                        {1,1,1,1,1,1,1,1,1},
                        {1,0,1,1,1,0,1,1,1},
                        {1,1,1,1,1,1,1,1,1},
                        {1,1,1,0,1,1,1,1,1},
                        {1,1,1,1,1,1,1,1,1}
                        };
    public int[,] house= {                                    //0-no house, 1-house
                        {0,1,0,0,0,0,0,0,0},
                        {0,1,0,0,0,0,0,0,0},
                        {0,0,0,0,0,1,0,0,0},
                        {0,0,0,0,0,0,0,0,0},
                        {0,1,0,0,0,1,0,0,0},
                        {0,0,0,0,0,1,0,0,0},
                        {0,0,0,0,0,0,0,0,0},
                        {0,0,0,1,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0}
                        };
    public int[] mainhouse={3,3}; 
    public int [,] playerfigures={{0,0},{1,0},{3,0}}; //Player, x-y coordinates
    void Awake(){
    }
    void Start()
    {
        //GameObject referenceTile =(GameObject)Instantiate((GameObject)Instantiate(Resources.Load("FieldPrefab")), transform);
        for(int x=0;x<9;x++) for(int y=0;y<9;y++){
            GameObject tile =(GameObject)Instantiate(referenceTile, transform);
            tile.transform.position = new Vector2(128/pixelsperunit*x+260, 128/pixelsperunit*y+40);
            //tile.transform.localScale = new Vector3(50,50,50);
            if(map[x,y]==1) tile.GetComponent<SpriteRenderer>().sprite = SpriteRenderer2; //(x+y)%2==1
            else tile.GetComponent<SpriteRenderer>().sprite = SpriteRenderer1;
        }
        Destroy(GameObject.Find("FieldPrefab(Clone)"));
    }
}
