using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnergyDisplayScript : MonoBehaviour
{
    [SerializeField] GameObject tman;
    [SerializeField] TMP_Text display;
    TurnManager turnmanager;

    // Start is called before the first frame update
    void Awake()
    {
        turnmanager=tman.GetComponent<TurnManager>();
    }
    void Start()
    {
        display.text="Energy left: 100";
    }

    // Update is called once per frame
    void Update()
    {
        display.text="Energy left: "+turnmanager.energy;
    }
}
