using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureAttributeScript : MonoBehaviour
{
    public int index;
    public bool player;
    public int health;
    public int moverange;
    public int movesleft;
    public string getinfotext(){
        return "Figure "+(index+1)+": "+(player? "Player": "Enemy")+"\nHealth: "+health+"\nMoves left: "+movesleft;
    }
}
