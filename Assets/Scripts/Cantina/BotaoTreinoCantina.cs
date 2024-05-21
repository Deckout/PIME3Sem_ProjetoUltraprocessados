using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoTreinoCantina : MonoBehaviour
{
        public Animator transition;
        public float transitionTime = 1f;
        public void Treino()
    {
        StartCoroutine(PlayGame("MinijogoCorrida"));
    }

    IEnumerator PlayGame(string levelName){
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadSceneAsync(levelName);
    }
}
