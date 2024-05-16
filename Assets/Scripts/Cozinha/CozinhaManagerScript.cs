using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class CozinhaManagerScript : MonoBehaviour
{
    public BarrasManager acessoBarrasManager;
    public int[,] itemComida = new int[6,11];
    public float tempo;
    public Text TempoTxt;

    void Awake(){
        tempo = 40;
    }
    void Start()
    {

        TempoTxt.text = "Tempo: " + tempo.ToString() + " minutos";

        //ID's comida
        itemComida[1, 1] = 1; //salada de frutas
        itemComida[1, 2] = 2; //Suco Natural
        itemComida[1, 3] = 3; //Iogurte com Granola
        itemComida[1, 4] = 4; //gelatina
        itemComida[1, 5] = 5; //Refri Zero
        itemComida[1, 6] = 6; //Barra de Cereal
        itemComida[1, 7] = 7; //Refresco de Laranja
        itemComida[1, 8] = 8; //Gelatina
        itemComida[1, 9] = 9; //Cereal Genérico de Chocolate
        itemComida[1, 10] = 10; //Refri

        //tempo em quantidade gasto
        itemComida[2, 1] = 15;
        itemComida[2, 2] = 10;
        itemComida[2, 3] = 10;
        itemComida[2, 4] = 5;
        itemComida[2, 5] = 5;
        itemComida[2, 6] = 5;
        itemComida[2, 7] = 5;
        itemComida[2, 8] = 5;
        itemComida[2, 9] = 10;
        itemComida[2, 10] = 5;

        //aqui embaixo, colocar a quantidade que mudará as variáveis saúde, energia e mentalidade
        //valor de cada alimento para saúde
        itemComida[3, 1] = 15; //10, teste
        itemComida[3, 2] = 10;
        itemComida[3, 3] = -15;
        itemComida[3, 4] = -5;
        itemComida[3, 5] = -5;
        itemComida[3, 6] = -10;
        itemComida[3, 7] = -10;
        itemComida[3, 8] = -5;
        itemComida[3, 9] = -5;
        itemComida[3, 10] = -10;

        //valor de cada alimento para energia;
        itemComida[4, 1] = 10;
        itemComida[4, 2] = 8;
        itemComida[4, 3] = 15;
        itemComida[4, 4] = 5;
        itemComida[4, 5] = 5;
        itemComida[4, 6] = 15;
        itemComida[4, 7] = 10;
        itemComida[4, 8] = 10;
        itemComida[4, 9] = 15;
        itemComida[4, 10] = 15;

        //valor de cada alimento para mentalidade;
        itemComida[5, 1] = 10;
        itemComida[5, 2] = 5;
        itemComida[5, 3] = 15;
        itemComida[5, 4] = 15;
        itemComida[5, 5] = 10;
        itemComida[5, 6] = 10;
        itemComida[5, 7] = 15;
        itemComida[5, 8] = 15;
        itemComida[5, 9] = 20;
        itemComida[5, 10] = 20;
    }

    public void Comprar()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        //checa se a quantidade de tempo disponível é inferior ou igual ao custo de tempo da comida escolhida, update texto tempo
        if (tempo >= itemComida[2, ButtonRef.GetComponent<FoodButtonInfo>().ItemID])
        {
            tempo -= itemComida[2, ButtonRef.GetComponent<FoodButtonInfo>().ItemID];
            TempoTxt.text = "Tempo: " + tempo.ToString() + " minutos";
            BarrasManager.currentSaude += itemComida[3, ButtonRef.GetComponent<FoodButtonInfo>().ItemID];
            BarrasManager.currentEnergia += itemComida[4, ButtonRef.GetComponent<FoodButtonInfo>().ItemID];
            BarrasManager.currentMentalidade += itemComida[5, ButtonRef.GetComponent<FoodButtonInfo>().ItemID];
        }
    }
}
