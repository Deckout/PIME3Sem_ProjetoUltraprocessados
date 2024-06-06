using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    public void PlayGame(){
        StartCoroutine(PlayGame("Transicao"));
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public IEnumerator PlayGame(string levelName){
        
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadSceneAsync(levelName);
    }

}
