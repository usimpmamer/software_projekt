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
        level1.name="Level 1";
        level1.map=new int[,] { 	{1,3,3,4,3,3,0,0,2},
                                    {1,3,5,3,3,0,0,2,2},
                                    {3,3,3,3,4,0,2,2,4},
                                    {3,0,3,0,0,0,2,2,2},
                                    {0,4,4,0,0,0,0,0,2},
                                    {0,0,0,0,4,0,0,0,0},
                                    {3,3,4,3,3,0,0,0,0},
                                    {3,3,1,1,3,3,0,0,2},
                                    {0,3,3,3,3,0,0,0,2}};

        
        /*{{1,0,1,1,1,1,1,1,1},                                  //1-gras, 0-gebirge, 2-...
                    {1,1,1,1,1,1,1,1,1},
                    {1,1,1,1,1,0,1,1,1},
                    {1,1,1,0,1,1,1,1,1},
                    {1,1,1,1,1,1,1,1,1},
                    {1,0,1,1,1,0,1,1,1},
                    {1,1,1,1,1,1,1,1,1},
                    {1,1,1,0,1,1,1,1,1},
                    {1,1,1,1,1,1,1,1,1}};*/
        level1.house=new int[,] {                                    //0-no house, 1-house
                        {0,1,0,0,0,0,0,0,0},
                        {0,1,0,0,0,0,0,0,0},
                        {0,0,0,0,0,1,0,0,0},
                        {0,0,0,0,0,0,0,0,0},
                        {0,1,0,0,0,1,0,0,0},
                        {0,0,0,0,0,1,0,0,0},
                        {0,0,0,0,0,0,0,0,0},
                        {0,0,0,1,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0}};
        level1.figures.Add(new int[] {0,0}); //Player
        level1.figures.Add(new int[] {1,0}); //Player
        level1.figures.Add(new int[] {2,0}); //Player
        level1.figures.Add(new int[] {5,5}); //Enemy
    }    
    void Start()
    {
    }
}
