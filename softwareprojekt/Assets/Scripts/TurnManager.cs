using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnManager : MonoBehaviour
{
    public int energy=100;
    [SerializeField] 
    private TMP_Text TurnDisplay; //Rundenanzeige (oben links)
    [SerializeField]
    public int turn=-1; //0 ... Spieler dran, 1... Gegner
    
    void start(){
        TurnDisplay.text="Your turn";
    }
    
    public void FieldInput(int i, int j){
        Debug.Log(i+", "+j);
    }
    

    public void EndPlayerTurn(){
        turn=1;
        TurnDisplay.text="Opponent's turn";
    }

    public void EndOpponentTurn(){
        turn=0;
        energy=100;
        TurnDisplay.text="Your turn";
    }
}
