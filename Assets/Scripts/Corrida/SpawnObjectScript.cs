using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnObjectScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float aceleracao = 0.1f;
    static public float velMax = 16f;
    static public float velAtual = 12f;
    private float timer;
    private float stamina;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        stamina = PlayerMovement.currentStamina;
        velAtual = 12f;
        timer = 0;

    }

    void Update()
    {
        if (PlayerMovement.currentStamina <= 0)
        {
            rb.velocity = Vector2.zero;
        }
        else
        {

            //aceleração gradual
            velAtual += aceleracao * Time.deltaTime;
            rb.velocity = new Vector2(-velAtual, rb.velocity.y);

            //limite de velocidade
            if (velAtual > velMax){
                velAtual = velMax;
            }
            else if (velAtual < 0){
                velAtual = 0;
            }
            
            //timer de spawn de objeto
            timer += Time.deltaTime;
            
            //tempo até ser destruido um novo spawn
            if(timer > 15){
                Destroy(gameObject);
            }
        }

    }
}
