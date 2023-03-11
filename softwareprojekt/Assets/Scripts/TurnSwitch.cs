using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject tman;
    TurnManager turnmanager;
    void Awake()
    {
        turnmanager=tman.GetComponent<TurnManager>();
    }
    public void switchturn(){
        if(turnmanager.turn) turnmanager.EndPlayerTurn();
        else turnmanager.EndOpponentTurn();
    }
}
