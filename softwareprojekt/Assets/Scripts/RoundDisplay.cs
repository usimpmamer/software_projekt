using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RoundDisplay : MonoBehaviour
{
    //[SerializeField] TMP_Text rdisplay;
    public void round(int i){
        this.gameObject.GetComponent<TMP_Text>().text="Round: "+i;
    } 
}
