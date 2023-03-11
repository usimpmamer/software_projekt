using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateLevel : MonoBehaviour
{
    [SerializeField] public GameObject levelobject;
    LevelProperties level1;
    // Start is called before the first frame update
    void Awake()
    {
        level1=levelobject.GetComponent<LevelProperties>();
    }    
    void Start()
    {
        /*level1.name="Level 1";
        level1.map={{1,0,1,1,1,1,1,1,1},                                  //1-gras, 0-gebirge, 2-...
                    {1,1,1,1,1,1,1,1,1},
                    {1,1,1,1,1,0,1,1,1},
                    {1,1,1,0,1,1,1,1,1},
                    {1,1,1,1,1,1,1,1,1},
                    {1,0,1,1,1,0,1,1,1},
                    {1,1,1,1,1,1,1,1,1},
                    {1,1,1,0,1,1,1,1,1},
                    {1,1,1,1,1,1,1,1,1}};
        level1.house={                                    //0-no house, 1-house
                        {0,1,0,0,0,0,0,0,0},
                        {0,1,0,0,0,0,0,0,0},
                        {0,0,0,0,0,1,0,0,0},
                        {0,0,0,0,0,0,0,0,0},
                        {0,1,0,0,0,1,0,0,0},
                        {0,0,0,0,0,1,0,0,0},
                        {0,0,0,0,0,0,0,0,0},
                        {0,0,0,1,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0}};
        int[] temp={0,0};
        level1.figures.Add(temp); //Player
        level1.figures.Add(1); //Player
        level1.figures.Add(2); //Player
        level1.figures.Add(4); //Enemy*/
    }
}
