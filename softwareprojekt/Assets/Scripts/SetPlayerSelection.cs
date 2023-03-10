using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPlayerSelection : MonoBehaviour
{
    FigureActions figureactions;
    [SerializeField] GameObject faction;
    [SerializeField] GameObject _tofocus;
    void Awake(){
        figureactions=faction.GetComponent<FigureActions>();
    }
    public void focusplayer(){
        figureactions.selectedObject=_tofocus;
        //gameObject.GetComponent<Image>().color=Color.red;
    }
}
