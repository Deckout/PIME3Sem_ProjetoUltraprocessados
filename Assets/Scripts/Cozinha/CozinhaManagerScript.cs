using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class CozinhaManagerScript : MonoBehaviour
{

    public int[,] itemComida = new int[3,5];
    public float tempo;
    public Text TempoTxt;
    void Start()
    {
        TempoTxt.text = "Tempo: " + tempo.ToString() + " minutos";

        //ID's comida
        itemComida[1, 1] = 1;
        itemComida[1, 2] = 2;
        itemComida[1, 3] = 3;
        itemComida[1, 4] = 4;
 
        //tempo em quantidade gasto
        itemComida[2, 1] = 5;
        itemComida[2, 2] = 10;
        itemComida[2, 3] = 40;
        itemComida[2, 4] = 5;

        //aqui embaixo, colocar a quantidade que mudará as variáveis saúde, energia e mentalidade
    }

    public void Comprar()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        //checa se a quantidade de tempo disponível é inferior ou igual ao custo de tempo da comida escolhida, update texto tempo
        if (tempo >= itemComida[2, ButtonRef.GetComponent<FoodButtonInfo>().ItemID])
        {
            tempo -= itemComida[2, ButtonRef.GetComponent<FoodButtonInfo>().ItemID];
            TempoTxt.text = "Tempo: " + tempo.ToString() + " minutos";
        }
    }
}
