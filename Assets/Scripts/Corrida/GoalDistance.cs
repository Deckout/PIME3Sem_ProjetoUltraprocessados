using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalDistance : MonoBehaviour
{
    public Text goalDistance;

    void Update()
    {
        if(TempoManager.ano == 2){
            goalDistance.gameObject.SetActive(true);
        }else{
            goalDistance.gameObject.SetActive(false);
        }
        if(TempoManager.ano == 5){
            goalDistance.gameObject.SetActive(true);
            goalDistance.text = "Meta: 100 metros";
        }
        
    }
}
