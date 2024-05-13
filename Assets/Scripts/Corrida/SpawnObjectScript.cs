using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnObjectScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private float timer;
    private float stamina;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        stamina = PlayerMovement.currentStamina;

    }

    void Update()
    {
        if (PlayerMovement.currentStamina <= 0)
        {
            rb.velocity = Vector2.zero;
        }
        else
        {
            rb.velocity = Vector2.left * speed;
            timer += Time.deltaTime;
            if(timer > 5){
                Destroy(gameObject);
            }
        }

    }
}
