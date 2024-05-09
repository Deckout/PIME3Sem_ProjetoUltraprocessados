using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciadorBarras : MonoBehaviour
{
    public float maxSaude = 100;
    public float maxEnergia = 100;
    public float maxMentalidade = 100;
    public float currentSaude;
    public float currentEnergia;
    public float currentMentalidade;
    [SerializeField] private Image saudeBarraFill;
    [SerializeField] private Image energiaBarraFill;
    [SerializeField] private Image mentalidadeBarraFill;

    void Start()
    {
        currentSaude = maxSaude;
        currentEnergia = maxEnergia;
        currentMentalidade = maxMentalidade;
    }

    public void UpdateSaude(float amountSaude){
        currentSaude += amountSaude;
        UpdateSaudeBarra();
    }

    public void UpdateEnergia(float amountEnergia){
        currentEnergia += amountEnergia;
        UpdateEnergiaBarra();
    }

    public void MentalidadeEnergia(float amountMentalidade){
        currentMentalidade += amountMentalidade;
        UpdateMentalidadeBarra();
    }

    public void UpdateSaudeBarra(){
        float targetSaudeFillAmount = currentSaude / maxSaude;
        saudeBarraFill.fillAmount = targetSaudeFillAmount;
    }

    public void UpdateEnergiaBarra(){
        float targetEnergiaFillAmount = currentEnergia / maxEnergia;
        energiaBarraFill.fillAmount = targetEnergiaFillAmount;
    }

    public void UpdateMentalidadeBarra(){
        float targetMentalidadeFillAmount = currentMentalidade / maxMentalidade;
        mentalidadeBarraFill.fillAmount = targetMentalidadeFillAmount;
    }

    public float getCurrentSaude(){
        return currentSaude;
    }
}
