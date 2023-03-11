using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class FigureActions : MonoBehaviour
{
    MyGridManager mygridmanager;
    [SerializeField]
    public GameObject tman, figure1, figure2, figure3, selectedObject, gmanager;
    [SerializeField] Camera cam;
    TurnManager turnmanager;
    void Awake()
    {
        turnmanager=tman.GetComponent<TurnManager>();
        mygridmanager=gmanager.GetComponent<MyGridManager>();
    }
    void Start()
    {
        
        moveto(figure2, mygridmanager.playerfigures[1,0], mygridmanager.playerfigures[1,1]);
        moveto(figure3, mygridmanager.playerfigures[2,0], mygridmanager.playerfigures[2,1]);
        moveto(figure1, mygridmanager.playerfigures[0,0], mygridmanager.playerfigures[0,1]);
        //moveto(figure3,1,1);
        //figure1.transform.position = new Vector3(-84+42*i,42*j,-1);
    }
    public void moveto(GameObject fig, int i, int j){
        //fig.transform.position = new Vector3(-498+42*i,-254+42*j,-1);
        fig.transform.position = figure1.transform.position+new Vector3(42*i,42*j,-1);
    }
    public void move(int i, int j){
        Vector3 newpos;
        int ipos;
        int jpos;
        if(turnmanager.energy>0){
            //wenn gebirgsfeld:
            newpos=selectedObject.transform.position + new Vector3(42*i,42*j,0);
            ipos=(int)(((selectedObject.transform.position + new Vector3(42*i,42*j,0)).x-455.439)/42);
            jpos=(int)(((selectedObject.transform.position + new Vector3(42*i,42*j,0)).y-253.249)/42);
            //Debug.Log("then x "+newpos.x+", then y "+newpos.y);
            if(mygridmanager.map[ipos,jpos]!=0){
                //Wenn von Spieler blockiert:
                //if(gmanager.map)
                selectedObject.transform.position = selectedObject.transform.position + new Vector3(42*i,42*j,0);
                turnmanager.energy-=1;
            }
        }
    }
    public int[] gridvalue(int coordinate, Vector3 pos){ //outputs the grid coordinates (integer from 0 to 8) converted from Vector3 position of an object
        int[] gridc={(int)(((pos).x-455.439)/42),(int)(((pos).y-253.249)/42)};
        /*gridc[0]=(int)(((pos).x-455.439)/42);
        gridc[1]=(int)(((pos).y-253.249)/42);*/
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
