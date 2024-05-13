using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject spawnObject;
    public GameObject[] spawnPoints;
    public float timer;
    public float timeBetweenSpawns;
    private float stamina;

    private float distance;
    public Text distanceUI;

    void Start(){
        stamina = PlayerMovement.currentStamina;
    }

    void Update()
    {
            if(PlayerMovement.currentStamina > 0){
                distanceUI.text = "Distância: " + distance.ToString("F1") + " metros";

                timer += Time.deltaTime;

                distance += Time.deltaTime * 1f;

            if(timer > timeBetweenSpawns){
                timer = 0;
                int randNum = Random.Range(0, 1);
                Instantiate(spawnObject, spawnPoints[randNum].transform.position, Quaternion.identity);
            }

        }
    }
}
