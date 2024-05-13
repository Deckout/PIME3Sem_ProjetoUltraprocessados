using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoFinalCorrida : MonoBehaviour
{
    public void CliqueFinal()
    {
        SceneManager.LoadSceneAsync("Comida");
        TempoManager.ano++;
        BarrasManager.currentEnergia -= 20;
        BarrasManager.currentSaude -= 20;
        BarrasManager.currentMentalidade -= 20;
    }
}

