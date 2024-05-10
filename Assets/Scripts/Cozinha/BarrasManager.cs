using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BarrasManager : MonoBehaviour
{
    
    public float maxSaude = 100;
    public float currentSaude = 100;
    [SerializeField] public Image saudeBarraFill;
    CozinhaManagerScript acessoCozinhaManagerScript;

    public Slider slide;

    public void Update(){

        saudeBarraFill.fillAmount = currentSaude / maxSaude;
        slide.value = currentSaude / maxSaude;
    }
    public void TirarValorSaude(int valorSaude){
        
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        valorSaude = acessoCozinhaManagerScript.itemComida[3, ButtonRef.GetComponent<FoodButtonInfo>().ItemID];
        
        currentSaude += valorSaude;
        currentSaude = Mathf.Clamp(currentSaude, 0, maxSaude);
        UpdateSaude();
    }

    public void UpdateSaude(){

        saudeBarraFill.fillAmount = currentSaude / maxSaude;
    }
}
