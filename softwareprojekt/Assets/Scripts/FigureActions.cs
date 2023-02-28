using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureActions : MonoBehaviour
{
    [SerializeField]
    private GameObject figure;

    public void moveto(int i, int j){
        figure.transform.position = new Vector3(-219,-61,0);
    }
    public void movetiles(int i, int j){
        figure.transform.position = figure.transform.position + new Vector3(42*i,42*j,0);
    }
    public void moveright(){
        figure.transform.position = figure.transform.position + new Vector3(42,0,0);
    }
}
