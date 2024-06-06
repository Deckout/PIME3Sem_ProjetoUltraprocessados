using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UpdateTextoCutscene : MonoBehaviour
{
    public TMP_Text texto1;
    public TMP_Text texto2;
    public TMP_Text texto3;
    public Image William;
    public Animator transition;
    public float transitionTime = 1f;
    void Start()
    {
        StartCoroutine(Waiting());
    }

    IEnumerator Waiting(){
        yield return new WaitForSeconds(8);

        texto1.gameObject.SetActive(false);
        texto2.gameObject.SetActive(false);
        texto3.gameObject.SetActive(true);
        William.gameObject.SetActive(false);

        yield return new WaitForSeconds(7);

        StartCoroutine(PlayGame("MainMenu"));
    }

    IEnumerator PlayGame(string levelName){
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadSceneAsync(levelName);
    }
}
