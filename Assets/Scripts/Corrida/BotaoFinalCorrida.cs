using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoFinalCorrida : MonoBehaviour
{
    [SerializeField] static public float contadorDist = 0;
    public void CliqueFinal()
    {
        SceneManager.LoadSceneAsync("Comida");
        TempoManager.ano++;
        BarrasManager.currentEnergia -= 30;
        BarrasManager.currentSaude -= 30;
        BarrasManager.currentMentalidade -= 30;
        contadorDist += GameManager.distance / 2f;
    }
}

