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

    private float distance;
    public Text distanceUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        distanceUI.text = "Distância: " + distance.ToString("F1");

        timer += Time.deltaTime;

        distance += Time.deltaTime * 0.8f;

        if(timer > timeBetweenSpawns)
        {
            timer = 0;
            int randNum = Random.Range(0, 1);
            Instantiate(spawnObject, spawnPoints[randNum].transform.position, Quaternion.identity);
        }
    }
}
