using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnManager : MonoBehaviour
{
    [SerializeField] 
    private TMP_Text TurnDisplay;
    public int turn=0; //0 ... Spieler dran, 1... Gegner
    void start(){
        TurnDisplay.text="Your turn";
    }
    public void EndPlayerTurn(){
        turn=1;
        TurnDisplay.text="Opponent's turn";
    }
    public void EndOpponentTurn(){
        turn=0;
        TurnDisplay.text="Your turn";
    }
}
