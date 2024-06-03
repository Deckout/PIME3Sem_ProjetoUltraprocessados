using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class FaceUpdaterCantina : MonoBehaviour
{
    public UnityEngine.UI.Image William3Neutro;
    public UnityEngine.UI.Image William3Doente;
    public UnityEngine.UI.Image William3Bem;
    public UnityEngine.UI.Image ProtagonistaFaceCantina;

    void Update(){
        if (TempoManager.ano >= 4){
            if(BarrasManager.currentEnergia <= 30 || BarrasManager.currentMentalidade <= 30 || BarrasManager.currentSaude <= 30){
                ProtagonistaFaceCantina.sprite = William3Doente.sprite;
            }
            else{
                if(BarrasManager.currentEnergia + BarrasManager.currentMentalidade + BarrasManager.currentSaude >= 210){
                ProtagonistaFaceCantina.sprite = William3Bem.sprite;
            }
                if(BarrasManager.currentEnergia + BarrasManager.currentMentalidade + BarrasManager.currentSaude >= 135 && BarrasManager.currentEnergia + BarrasManager.currentMentalidade + BarrasManager.currentSaude <= 209){
                ProtagonistaFaceCantina.sprite = William3Neutro.sprite;
            }
                if(BarrasManager.currentEnergia + BarrasManager.currentMentalidade + BarrasManager.currentSaude <= 134){
                ProtagonistaFaceCantina.sprite = William3Doente.sprite;
            }
        }
    }
    }
}
