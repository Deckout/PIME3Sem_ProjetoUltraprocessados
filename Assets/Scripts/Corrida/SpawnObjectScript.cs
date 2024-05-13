using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnObjectScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private float timer;
    public PlayerMovement playerMovement;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = Vector2.left * speed;

        timer += Time.deltaTime;
        if(timer > 5){
            Destroy(gameObject);
        }
    }
}
