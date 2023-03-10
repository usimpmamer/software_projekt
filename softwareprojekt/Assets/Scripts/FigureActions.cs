using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class FigureActions : MonoBehaviour
{
    [SerializeField]
    public GameObject tman, figure1, figure2, figure3, selectedObject;
    TurnManager turnmanager;
    void Awake()
    {
        turnmanager=tman.GetComponent<TurnManager>();
    }
/*
    public void moveto(int i, int j){
        figure1.transform.position = new Vector3(-219,-61,0);
    }
*/
    public void move(int i, int j){
        if(turnmanager.energy>0){
            selectedObject.transform.position = selectedObject.transform.position + new Vector3(i,j,0);
            turnmanager.energy-=1;
        }
    }
    public void focus1(){
        selectedObject=figure1;
    }
    public void focus2(){
        selectedObject=figure2;
    }
    public void focus3(){
        selectedObject=figure3;
    }
}
