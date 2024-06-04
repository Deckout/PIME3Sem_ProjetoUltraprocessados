using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class CantinaManagerScript : MonoBehaviour
{
    public BarrasManager acessoBarrasManager;
    public int[,] itemCantina = new int[6,14];
    public float tempo;
    public Text TempoTxt;

    void Awake(){
        tempo = 15;
    }
    void Start()
    {

        TempoTxt.text = "Tempo: " + tempo.ToString() + " minutos";

        //ID's comida
        itemCantina[1, 1] = 1; //lanche natural
        itemCantina[1, 2] = 2; //salada de fruta
        itemCantina[1, 3] = 3; //chocolate 70%
        itemCantina[1, 4] = 4; //barra de cereal
        itemCantina[1, 5] = 5; //refresco de laranja
        itemCantina[1, 6] = 6; //gelatina
        itemCantina[1, 7] = 7; //refri zero
        itemCantina[1, 8] = 8; //chocolate diet
        itemCantina[1, 9] = 9; //isotônico
        itemCantina[1, 10] = 10; //chocolate ao leite
        itemCantina[1, 11] = 11; //refri
        itemCantina[1, 12] = 12; //energético

        //tempo em quantidade gasto
        itemCantina[2, 1] = 5;
        itemCantina[2, 2] = 5;
        itemCantina[2, 3] = 5;
        itemCantina[2, 4] = 5;
        itemCantina[2, 5] = 5;
        itemCantina[2, 6] = 5;
        itemCantina[2, 7] = 5;
        itemCantina[2, 8] = 5;
        itemCantina[2, 9] = 5;
        itemCantina[2, 10] = 5;
        itemCantina[2, 11] = 5;
        itemCantina[2, 12] = 5;

        //aqui embaixo, colocar a quantidade que mudará as variáveis saúde, energia e mentalidade
        //valor de cada alimento para saúde
        itemCantina[3, 1] = 20;
        itemCantina[3, 2] = 15;
        itemCantina[3, 3] = 0;
        itemCantina[3, 4] = -10;
        itemCantina[3, 5] = -10;
        itemCantina[3, 6] = -5;
        itemCantina[3, 7] = -5;
        itemCantina[3, 8] = -5;
        itemCantina[3, 9] = -5;
        itemCantina[3, 10] = -15;
        itemCantina[3, 11] = -10;
        itemCantina[3, 12] = -15;

        //valor de cada alimento para energia;
        itemCantina[4, 1] = 8;
        itemCantina[4, 2] = 10;
        itemCantina[4, 3] = 5;
        itemCantina[4, 4] = 10;
        itemCantina[4, 5] = 5;
        itemCantina[4, 6] = 5;
        itemCantina[4, 7] = 5;
        itemCantina[4, 8] = 10;
        itemCantina[4, 9] = 10;
        itemCantina[4, 10] = 15;
        itemCantina[4, 11] = 15;
        itemCantina[4, 12] = 25;

        //valor de cada alimento para mentalidade;
        itemCantina[5, 1] = 8;
        itemCantina[5, 2] = 10;
        itemCantina[5, 3] = 5;
        itemCantina[5, 4] = 10;
        itemCantina[5, 5] = 15;
        itemCantina[5, 6] = 15;
        itemCantina[5, 7] = 10;
        itemCantina[5, 8] = 20;
        itemCantina[5, 9] = 10;
        itemCantina[5, 10] = 25;
        itemCantina[5, 11] = 20;
        itemCantina[5, 12] = 15;

    }

    public void Comprar()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        //checa se a quantidade de tempo disponível é inferior ou igual ao custo de tempo da comida escolhida, update texto tempo
        if (tempo >= itemCantina[2, ButtonRef.GetComponent<CantinaButtonInfo>().ItemID])
        {
            tempo -= itemCantina[2, ButtonRef.GetComponent<CantinaButtonInfo>().ItemID];
            TempoTxt.text = "Tempo: " + tempo.ToString() + " minutos";
            BarrasManager.currentSaude += itemCantina[3, ButtonRef.GetComponent<CantinaButtonInfo>().ItemID];
            BarrasManager.currentEnergia += itemCantina[4, ButtonRef.GetComponent<CantinaButtonInfo>().ItemID];
            BarrasManager.currentMentalidade += itemCantina[5, ButtonRef.GetComponent<CantinaButtonInfo>().ItemID];

    
        }
    }
}
