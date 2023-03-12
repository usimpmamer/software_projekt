using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelProperties : MonoBehaviour
{
    public string name;
    public int[,] map=new int[9,9];
    public int[,] house=new int[9,9];
    public int[] mainhouse={3,3}; 
    //public int [,] playerfigures={{0,0},{1,0},{3,0}}; //Player, x-y coordinates starting position
    public List<int[]> figures = new List<int[]>();
}
