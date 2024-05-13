using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [HideInInspector] public BarrasManager barrasManager;
    public float maxStamina = 0;
    public float currentStamina = 0;
    public Slider sliderStamina;
    [HideInInspector] public float jump;
    private Rigidbody2D rb;
    private bool isGrounded;
    private float custoJump = 5;


    void Start(){
        maxStamina = BarrasManager.currentSaude + BarrasManager.currentEnergia + BarrasManager.currentMentalidade / 3;
        currentStamina = maxStamina;
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //update barra stamina
        // Check if sliderStamina is not null before using it
        if(sliderStamina != null)
        {
            //update barra stamina
            currentStamina -= Time.deltaTime * 3;
            sliderStamina.value = currentStamina / maxStamina;
            if (currentStamina <= 0){
                currentStamina = 0;
        }
    }
    else
    {
        Debug.LogError("sliderStamina is not assigned!");
    }

        //requerimentos pulo
        if(Input.GetButtonDown("Jump") && isGrounded && currentStamina >= 5)
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
}
