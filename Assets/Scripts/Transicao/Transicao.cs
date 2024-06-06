using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Transicao : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public TMP_Text Ano;
    public TMP_Text Idade;
    public TMP_Text Local;
    void Start(){
        StartCoroutine(Transition());
    }

    IEnumerator Transition(){
        if(TempoManager.ano == 0){
            yield return new WaitForSeconds(5);

            StartCoroutine(PlayGame("Comida"));
        }
        if(TempoManager.ano == 2){
            Ano.text = "Ano 2";
            Idade.text = "15 anos";

            yield return new WaitForSeconds(5);

            StartCoroutine(PlayGame("Comida"));
        }
        if(TempoManager.ano == 3){
            Ano.text = "Ano 3";
            Idade.text = "16 anos";

            yield return new WaitForSeconds(5);

            StartCoroutine(PlayGame("Comida"));
        }
        if(TempoManager.ano == 4){
            Ano.text = "Ano 4";
            Idade.text = "17 anos";
            Local.text = "Cantina da escola";

            yield return new WaitForSeconds(5);

            StartCoroutine(PlayGame("Cantina"));
        }
        if(TempoManager.ano == 5){
            Ano.text = "Ano 5";
            Idade.text = "18 anos";
            Local.text = "Cantina da escola";

            yield return new WaitForSeconds(5);

            StartCoroutine(PlayGame("Cantina"));
        }
    }

    IEnumerator PlayGame(string levelName){
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadSceneAsync(levelName);
    }
}