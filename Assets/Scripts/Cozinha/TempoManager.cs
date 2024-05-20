using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TempoManager : MonoBehaviour
{
static public int ano;
static private bool inicio = false;
public TMP_Text contador_ano;

    public void Start()
    {
        if(inicio == false){
            ano = 1;
            inicio = true;
        } 
    }


    void Update()
    {
        contador_ano.text = "Ano " + ano;
    }
}
