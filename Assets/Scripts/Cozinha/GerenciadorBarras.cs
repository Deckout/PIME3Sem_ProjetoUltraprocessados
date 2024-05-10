using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciadorBarras : MonoBehaviour
{
    [Header("Valores Variáveis")]
    public float maxSaude = 100;
    public float maxEnergia = 100;
    public float maxMentalidade = 100;
    public float currentSaude = 100;
    public float currentEnergia = 100;
    public float currentMentalidade = 100;
    [SerializeField] private Image saudeBarraFill;
    [SerializeField] private Image energiaBarraFill;
    [SerializeField] private Image mentalidadeBarraFill;
    [Space]
    [SerializeField] private bool overkill;

    private void Start(){
        UpdateSaude();
    }
    public void UpdateSaude(){
        if (maxSaude <= 0)
        {
            saudeBarraFill.fillAmount = 0;
            return;
        }

        float saudeFillAmount = (float) currentSaude / maxSaude;

        saudeBarraFill.fillAmount = saudeFillAmount;
    }

    public bool MudarValorSaude(int valorSaude){
        if (!overkill && currentSaude + valorSaude < 0)
            return false;
        
        currentSaude += valorSaude;
        currentSaude = Mathf.Clamp(value:currentSaude, min:0, maxSaude);

        saudeBarraFill.fillAmount = (float) currentSaude / maxSaude;

        return true;

    }

}
