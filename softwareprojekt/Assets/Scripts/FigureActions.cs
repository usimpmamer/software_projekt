using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureActions : MonoBehaviour
{
    public static int energy=0;
    [SerializeField]
    private GameObject figure1, figure2, figure3;
    public int sf=1; //selected figure

    public void moveto(int i, int j){
        figure1.transform.position = new Vector3(-219,-61,0);
    }
    public void movetiles(int i, int j){
        figure1.transform.position = figure1.transform.position + new Vector3(42*i,42*j,0);
    }
    public void moveleft(){
        if(sf==1)      figure1.transform.position = figure1.transform.position + new Vector3(-42,0,0);
        else if(sf==2) figure2.transform.position = figure2.transform.position + new Vector3(-42,0,0);
        else if(sf==2) figure3.transform.position = figure3.transform.position + new Vector3(-42,0,0);
    }
    public void moveright(){
        if(sf==1)      figure1.transform.position = figure1.transform.position + new Vector3(42,0,0);
        else if(sf==2) figure2.transform.position = figure2.transform.position + new Vector3(42,0,0);
        else if(sf==2) figure3.transform.position = figure3.transform.position + new Vector3(42,0,0);
    }
    public void movedown(){
        if(sf==1)      figure1.transform.position = figure1.transform.position + new Vector3(0,-42,0);
        else if(sf==2) figure2.transform.position = figure2.transform.position + new Vector3(0,-42,0);
        else if(sf==2) figure3.transform.position = figure3.transform.position + new Vector3(0,-42,0);
    }
    public void moveup(){
        if(sf==1)      figure1.transform.position = figure1.transform.position + new Vector3(0,42,0);
        else if(sf==2) figure2.transform.position = figure2.transform.position + new Vector3(0,42,0);
        else if(sf==2) figure3.transform.position = figure3.transform.position + new Vector3(0,42,0);
    }
}
