using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class CozinhaManagerScript : MonoBehaviour
{
    public BarrasManager acessoBarrasManager;
    public int[,] itemComida = new int[6,5];
    public float tempo;
    public Text TempoTxt;
    void Start()
    {

        TempoTxt.text = "Tempo: " + tempo.ToString() + " minutos";

        //ID's comida
        itemComida[1, 1] = 1; //banana
        itemComida[1, 2] = 2; //ovo frito
        itemComida[1, 3] = 3; //arroz e feijao
        itemComida[1, 4] = 4; //energético
 
        //tempo em quantidade gasto
        itemComida[2, 1] = 5;
        itemComida[2, 2] = 10;
        itemComida[2, 3] = 40;
        itemComida[2, 4] = 5;

        //aqui embaixo, colocar a quantidade que mudará as variáveis saúde, energia e mentalidade
        //valor de cada alimento para saúde
        itemComida[3, 1] = -10; //10, teste
        itemComida[3, 2] = -10;
        itemComida[3, 3] = 30;
        itemComida[3, 4] = -25;

        //valor de cada alimento para energia;
        itemComida[4, 1] = 10;
        itemComida[4, 2] = 20;
        itemComida[4, 3] = 30;
        itemComida[4, 4] = 25;

        //valor de cada alimento para mentalidade;

        itemComida[5, 1] = 5;
        itemComida[5, 2] = 10;
        itemComida[5, 3] = -5;
        itemComida[5, 4] = 20;
    }

    public void Comprar()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        //checa se a quantidade de tempo disponível é inferior ou igual ao custo de tempo da comida escolhida, update texto tempo
        if (tempo >= itemComida[2, ButtonRef.GetComponent<FoodButtonInfo>().ItemID])
        {
            tempo -= itemComida[2, ButtonRef.GetComponent<FoodButtonInfo>().ItemID];
            TempoTxt.text = "Tempo: " + tempo.ToString() + " minutos";
            acessoBarrasManager.currentSaude += -10;//itemComida[3, ButtonRef.GetComponent<FoodButtonInfo>().SaudeID];
        }
    }
}
