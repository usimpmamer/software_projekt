using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButtons : MonoBehaviour
{
    FigureActions figureactions;
    [SerializeField] GameObject faction;
    void Awake(){
        figureactions=faction.GetComponent<FigureActions>();
    }
    public void moveleft(){
        figureactions.move(-42,0);
    }
    public void moveright(){
        figureactions.move(42,0);
    }
    public void moveup(){
        figureactions.move(0,42);
    }
    public void movedown(){
        figureactions.move(0,-42);
    }
}
