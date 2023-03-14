using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class FigureActions : MonoBehaviour
{
    LevelProperties levelprops;
    [SerializeField]
    public GameObject tman, figure1, figure2, figure3, selectedObject, level;
    [SerializeField] Camera cam;
    TurnManager turnmanager;
    void Awake()
    {
        turnmanager=tman.GetComponent<TurnManager>();
        levelprops=level.GetComponent<LevelProperties>();
    }
    void Start()
    {
        
        moveto(figure1, levelprops.figures[0][0], levelprops.figures[0][1]);
        moveto(figure2, levelprops.figures[1][0], levelprops.figures[1][1]);
        moveto(figure3, levelprops.figures[2][0], levelprops.figures[2][1]);
        //moveto(figure3,1,1);
        //figure1.transform.position = new Vector3(-84+42*i,42*j,-1);
    }
    public void moveto(GameObject fig, int i, int j){
        //fig.transform.position = new Vector3(-498+42*i,-254+42*j,-1);
        fig.transform.position = figure1.transform.position+new Vector3(42*i,42*j,-1);
        
    }
    public void move(int i, int j){
        int[] gridcoor;
        GameObject[] allfigs;
        FigureAttributeScript props=selectedObject.GetComponent<FigureAttributeScript>(); //properties des ausgewählten Objekts
        if(turnmanager.energy<=0) goto end;         //Wenn genügend Energie zur Verfügung steht
        if(props.movesleft<=0) goto end;
        gridcoor=gridvalue(selectedObject.transform.position + new Vector3(42*i,42*j,0));
        Debug.Log("Player to move to x="+gridcoor[0]+", y="+gridcoor[1]);
        if(levelprops.map[gridcoor[0],gridcoor[1]]==1) goto end;        //wenn gebirgsfeld
        if(levelprops.map[gridcoor[0],gridcoor[1]]==2) goto end;        //wenn wasserfeld
        //Wenn von Spieler blockiert:
        allfigs=GameObject.FindGameObjectsWithTag("Figure");
        //Debug.Log("2");
        for(int k=0;k<allfigs.Length;k++){
            //Debug.Log("Schritt 3, "+k);
            if(gridcoor[0]==gridvalue(allfigs[k].transform.position)[0]&&gridcoor[1]==gridvalue(allfigs[k].transform.position)[1]&&props.index!=allfigs[k].GetComponent<FigureAttributeScript>().index) goto end;
        }
        selectedObject.transform.position = selectedObject.transform.position + new Vector3(42*i,42*j,0);
        turnmanager.energy-=1;
        props.movesleft-=1;
        end:;
    }
    public int[] gridvalue(Vector3 pos){ //outputs the grid coordinates (integer from 0 to 8) converted from Vector3 position of an object
        //Debug.Log("transform x="+pos.x+", y="+pos.y+", z="+pos.z);
        int[] gridc={(int)(((pos).x-454.639)/42),(int)(((pos).y-253.249)/42)}; //x=-455.439, new x=-454.639
        return gridc;
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
