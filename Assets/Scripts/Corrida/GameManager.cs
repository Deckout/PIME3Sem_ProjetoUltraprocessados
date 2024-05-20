using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Security.Cryptography;

public class GameManager : MonoBehaviour
{

    public GameObject spawnObject;
    public GameObject pontoChegada;
    public GameObject[] spawnPoints;
    public float timer;
    public float tempoTotal;
    public float timeBetweenSpawns;
    public bool pontoChegadaJa = false;
    private float stamina;
    static public float distance;
    public Button finalizarCorrida;
    public Text distanceUI;

    void Start(){
        stamina = PlayerMovement.currentStamina;

        finalizarCorrida.interactable = false;
        finalizarCorrida.gameObject.SetActive(false);
        distance = 0;
    }

    void Update()
    {
            if(PlayerMovement.currentStamina > 0 && CountdownManager.countdownOver == true){
                distanceUI.text = "Distância: " + distance.ToString("F1") + " metros";

                timer += Time.deltaTime;

                distance += (Time.deltaTime * SpawnObjectScript.velAtual)/4;

                tempoTotal += Time.deltaTime;

        if(TempoManager.ano == 0 && CountdownManager.countdownOver == true){
            if(timer > timeBetweenSpawns){
                timeBetweenSpawns = Random.Range(0.8f, 2f);
                timer = 0;
                int randNum = Random.Range(0, 1);
                Instantiate(spawnObject, spawnPoints[randNum].transform.position, Quaternion.identity);
                }

            }
        if(TempoManager.ano == 1 && CountdownManager.countdownOver == true){
            if(timer > timeBetweenSpawns){
                timeBetweenSpawns = Random.Range(0.8f, 2f);
                timer = 0;
                int randNum = Random.Range(0, 1);
                Instantiate(spawnObject, spawnPoints[randNum].transform.position, Quaternion.identity);
                }

            }
        if(TempoManager.ano == 2 && CountdownManager.countdownOver == true){
            if(timer > timeBetweenSpawns && distance <= 58){
                timeBetweenSpawns = Random.Range(0.8f, 2f);
                timer = 0;
                int randNum = Random.Range(0, 1);
                Instantiate(spawnObject, spawnPoints[randNum].transform.position, Quaternion.identity);
                }
            if(distance >= 60 && pontoChegadaJa == false && CountdownManager.countdownOver == true){
                int randNum = Random.Range(0, 1);
                Instantiate(pontoChegada, spawnPoints[randNum].transform.position, Quaternion.identity);
                pontoChegadaJa = true;
                }
            }
        if(TempoManager.ano == 3 && CountdownManager.countdownOver == true){
            if(timer > timeBetweenSpawns){
                timeBetweenSpawns = Random.Range(0.8f, 2f);
                timer = 0;
                int randNum = Random.Range(0, 1);
                Instantiate(spawnObject, spawnPoints[randNum].transform.position, Quaternion.identity);
                }
            }
        if(TempoManager.ano == 4 && CountdownManager.countdownOver == true){
            if(timer > timeBetweenSpawns){
                timeBetweenSpawns = Random.Range(0.8f, 2f);
                timer = 0;
                int randNum = Random.Range(0, 1);
                Instantiate(spawnObject, spawnPoints[randNum].transform.position, Quaternion.identity);
                }
            }
        if(TempoManager.ano == 5 && CountdownManager.countdownOver == true){
            if(timer > timeBetweenSpawns && distance <= 98){
                timeBetweenSpawns = Random.Range(0.8f, 2f);
                timer = 0;
                int randNum = Random.Range(0, 1);
                Instantiate(spawnObject, spawnPoints[randNum].transform.position, Quaternion.identity);
                }
            if(distance >= 100 && pontoChegadaJa == false){
                int randNum = Random.Range(0, 1);
                Instantiate(pontoChegada, spawnPoints[randNum].transform.position, Quaternion.identity);
                pontoChegadaJa = true;
                }
            }
        }
        if(PlayerMovement.currentStamina <= 0){
                    finalizarCorrida.interactable = true;
                    finalizarCorrida.gameObject.SetActive(true);
        }
    }
}
