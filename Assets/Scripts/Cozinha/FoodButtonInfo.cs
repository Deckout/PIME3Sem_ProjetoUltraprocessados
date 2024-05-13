using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FoodButtonInfo : MonoBehaviour
{

    public int ItemID;
    public TMP_Text CustoTempoTxt;
    public GameObject CozinhaManager;
    

    void Update()
    {
        CustoTempoTxt.text = "Tempo: " + CozinhaManager.GetComponent<CozinhaManagerScript>().itemComida[2, ItemID].ToString() + " minutos";
    }
}
