using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnManager : MonoBehaviour
{
    //Scripts:
    RoundDisplay rounddisplay;
    //Placehoulders
    [SerializeField] 
    private TMP_Text TurnDisplay, rdisplay; //Rundenanzeige (oben links)
    public int energy=100;
    public int round=1;
    public bool turn=true; //true ... Spieler dran, false... Gegner
    void Awake(){
        rounddisplay=rdisplay.GetComponent<RoundDisplay>();
    }
    void start(){
        TurnDisplay.text="Your turn";
        Debug.Log("haha");
        rounddisplay.round(1);
    }
    
    public void FieldInput(int i, int j){
        Debug.Log(i+", "+j);
    }
    

    public void EndPlayerTurn(){
        turn=false;
        TurnDisplay.text="Opponent's turn";
        EndOpponentTurn();
        //Opponents turn:
        
    }

    public void EndOpponentTurn(){
        turn=true;
        energy=100;
        round+=1;
        TurnDisplay.text="Your turn";
        rounddisplay.round(round);
    }
}
