using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class FaceUpdater : MonoBehaviour
{
    public UnityEngine.UI.Image William1Neutro;
    public UnityEngine.UI.Image William1Doente;
    public UnityEngine.UI.Image William1Bem;
    public UnityEngine.UI.Image William2Neutro;
    public UnityEngine.UI.Image William2Doente;
    public UnityEngine.UI.Image William2Bem;
    public UnityEngine.UI.Image ProtagonistaFace;

    void Update(){
        if (TempoManager.ano <= 2){
            if(BarrasManager.currentEnergia <= 30 || BarrasManager.currentMentalidade <= 30 || BarrasManager.currentSaude <= 30){
                ProtagonistaFace.sprite = William1Doente.sprite;
            }
            else{
                if(BarrasManager.currentEnergia + BarrasManager.currentMentalidade + BarrasManager.currentSaude >= 210){
                ProtagonistaFace.sprite = William1Bem.sprite;
            }
                if(BarrasManager.currentEnergia + BarrasManager.currentMentalidade + BarrasManager.currentSaude >= 135 && BarrasManager.currentEnergia + BarrasManager.currentMentalidade + BarrasManager.currentSaude <= 209){
                ProtagonistaFace.sprite = William1Neutro.sprite;
            }
                if(BarrasManager.currentEnergia + BarrasManager.currentMentalidade + BarrasManager.currentSaude <= 134){
                ProtagonistaFace.sprite = William1Doente.sprite;
            }
        }
    }
        if (TempoManager.ano >= 3){
            if(BarrasManager.currentEnergia <= 30 || BarrasManager.currentMentalidade <= 30 || BarrasManager.currentSaude <= 30){
                ProtagonistaFace.sprite = William2Doente.sprite;
            }
            else{
                if(BarrasManager.currentEnergia + BarrasManager.currentMentalidade + BarrasManager.currentSaude >= 210){
                ProtagonistaFace.sprite = William2Bem.sprite;
            }
                if(BarrasManager.currentEnergia + BarrasManager.currentMentalidade + BarrasManager.currentSaude >= 135 && BarrasManager.currentEnergia + BarrasManager.currentMentalidade + BarrasManager.currentSaude <= 209){
                ProtagonistaFace.sprite = William2Neutro.sprite;
            }
                if(BarrasManager.currentEnergia + BarrasManager.currentMentalidade + BarrasManager.currentSaude <= 134){
                ProtagonistaFace.sprite = William2Doente.sprite;
            }
        }
    }
    }
}
