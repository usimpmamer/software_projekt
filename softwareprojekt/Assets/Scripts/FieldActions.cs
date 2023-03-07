using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldActions : MonoBehaviour
{
    TurnManager turnmanager;
    [SerializeField] GameObject tman;



    void start()
    {
        turnmanager=tman.GetComponent<TurnManager>();
    }
    /* 
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        //turnmanager.FieldInput((int)((myfield.transform.position.x-260)/128*3), (int)((myfield.transform.position.y-40)/128*3));
    }*/
}