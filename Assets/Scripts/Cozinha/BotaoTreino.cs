using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoTreino : MonoBehaviour
{

        public void Treino()
    {
        SceneManager.LoadSceneAsync("MinijogoCorrida");
    }
}
