using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TempoManager : MonoBehaviour
{
static public int ano;
static private bool inicio = false;
public TMP_Text contador_ano;
public UnityEngine.UI.Image bgCozinha;
public UnityEngine.UI.Image bgCantina;

    public void Start()
    {
        if(inicio == false){
            ano = 1;
            inicio = true;
        }
        
        bgCozinha.enabled = true;
    }


    void Update()
    {
        contador_ano.text = "Ano " + ano;

        if(ano >= 4){
            bgCozinha.enabled = false;
            bgCantina.enabled = true;
        }
    }
}
