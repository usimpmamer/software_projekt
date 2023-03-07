using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectionScript : MonoBehaviour
{
    FigureActions _figure1actions;
    FigureActions _figure2actions;
    FigureActions _figure3actions;
    [SerializeField] GameObject figure1;
    [SerializeField] GameObject figure2;
    [SerializeField] GameObject figure3;

    void Awake(){
        _figure1actions=figure1.GetComponent<FigureActions>();
        _figure2actions=figure2.GetComponent<FigureActions>();
        _figure3actions=figure3.GetComponent<FigureActions>();
    }
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        _figure1actions.sf=2;
        _figure2actions.sf=2;
        _figure3actions.sf=2;
        Debug.Log("hahah");
    }
}
