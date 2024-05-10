using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBarra : MonoBehaviour
{
    [SerializeField] private int valorID = 10;
    [SerializeField] private GerenciadorBarras gerenciadorBarras;

    public void ChangeSaude(){
        bool changeSuccessful = gerenciadorBarras.MudarValorSaude(valorID);

        if(changeSuccessful)
            Debug.Log(message:"Cast successful");
        else
            Debug.Log(message:"Cast failed due to lack of Saude");
    }
}
