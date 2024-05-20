using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownManager : MonoBehaviour
{
    public int countdownTime;
    public TMP_Text countdownDisplay;

    static public bool countdownOver;

    private void Start(){
        countdownOver = false;
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart(){
        while(countdownTime > 0){
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countdownDisplay.text = "Vai!";

        //colocar aqui um "game start"
        countdownOver = true;

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);
    }
}
