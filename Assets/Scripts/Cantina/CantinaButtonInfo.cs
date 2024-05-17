using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CantinaButtonInfo : MonoBehaviour
{

    public int ItemID;
    public TMP_Text CustoTempoTxt;
    public GameObject CantinaManager;
    

    void Update()
    {
        CustoTempoTxt.text = "Tempo: " + CantinaManager.GetComponent<CantinaManagerScript>().itemCantina[2, ItemID].ToString() + " minutos";
    }
}
