using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BarrasManager : MonoBehaviour
{
    
    public float maxSaude = 100;
    public float maxEnergia = 100;
    public float maxMentalidade = 100;
    public float currentSaude = 100;
    public float currentEnergia = 100;
    public float currentMentalidade = 100;
    CozinhaManagerScript acessoCozinhaManagerScript;

    public Slider SliderSaude;
    public Slider SliderEnergia;
    public Slider SliderMentalidade;

    public void Update(){
        
        SliderSaude.value = currentSaude / maxSaude;
        SliderEnergia.value = currentEnergia / maxEnergia;
        SliderMentalidade.value = currentMentalidade / maxMentalidade;

        if(currentSaude <= 0){
            currentSaude = 0;
        }
        if(currentEnergia <= 0){
            currentEnergia = 0;
        }        
        if(currentMentalidade <= 0){
            currentMentalidade = 0;
        }
        if(currentSaude >= 100){
            currentSaude = 100;
        }
        if(currentEnergia >= 100){
            currentEnergia = 100;
        }        
        if(currentMentalidade >= 100){
            currentMentalidade = 100;
        }

    }
}
