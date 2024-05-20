using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoFinalCorrida : MonoBehaviour
{
    static public float contadorDist = 0;
    public Animator transition;
    public float transitionTime = 1f;

    public void CliqueFinal()
    {
        if(TempoManager.ano > 2){
            StartCoroutine(PlayGame("Cantina"));
        }
        else{
        StartCoroutine(PlayGame("Comida"));
        }
        if(TempoManager.ano > 4){
            StartCoroutine(PlayGame("Final"));
        }
        TempoManager.ano++;
        BarrasManager.currentEnergia -= 30;
        BarrasManager.currentSaude -= 30;
        BarrasManager.currentMentalidade -= 30;
        contadorDist += GameManager.distance / 1.2f;
    }

    IEnumerator PlayGame(string levelName){
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadSceneAsync(levelName);
    }
}

