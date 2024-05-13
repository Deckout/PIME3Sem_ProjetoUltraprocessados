using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [HideInInspector] public BarrasManager barrasManager;
    static public float maxStamina = 0;
    static public float currentStamina = 0;
    public Slider sliderStamina;
    public float jump;
    private Rigidbody2D rb;
    private bool isGrounded;
    private float custoJump = 5;


    void Start(){
        maxStamina = BarrasManager.currentSaude + BarrasManager.currentEnergia + BarrasManager.currentMentalidade * 1/2;
        currentStamina = maxStamina;
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

            //update barra stamina
            currentStamina -= Time.deltaTime * 3;
            sliderStamina.value = currentStamina / maxStamina;
            if (currentStamina <= 0){
                currentStamina = 0;
        }
        
        //requerimentos pulo
        if(Input.GetButtonDown("Jump") && isGrounded && currentStamina >= 1)
        {
            rb.AddForce(Vector2.up * jump);

            currentStamina -= custoJump;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Obstáculo")){
            currentStamina -= 10;
        }
        if (other.gameObject.CompareTag("LinhaChegada")){
            currentStamina = 0;
        }
    }
}
