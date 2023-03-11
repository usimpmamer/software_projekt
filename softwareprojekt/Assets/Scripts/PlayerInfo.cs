using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] TMP_Text display;
    [SerializeField] GameObject figaction;
    FigureActions figureactions;
    // Start is called before the first frame update
    void Awake()
    {
        figureactions=figaction.GetComponent<FigureActions>();
    }
    void Start()
    {
        display.text=figureactions.selectedObject.GetComponent<FigureAttributeScript>().getinfotext();
    }

    // Update is called once per frame
    void Update()
    {
        display.text=figureactions.selectedObject.GetComponent<FigureAttributeScript>().getinfotext();
    }
}
