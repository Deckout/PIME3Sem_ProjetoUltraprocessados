using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [HideInInspector] public BarrasManager barrasManager;
    private readonly GameManager manager;
    static public float maxStamina = 0;
    static public float currentStamina = 0;
    public Slider sliderStamina;
    public float jump = 360;
    private Rigidbody2D rb;
    private bool isGrounded;
    private float custoJump = 5;
    private bool isInCollision = false;
    public TMP_Text numStam;

    void Start(){
        maxStamina = (BarrasManager.currentSaude + BarrasManager.currentEnergia + BarrasManager.currentMentalidade + BotaoFinalCorrida.contadorDist) / 2;
        currentStamina = maxStamina;
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //texto barra stamina
        numStam.text = currentStamina.ToString("F0") + "/" + maxStamina.ToString("F0");

        //update barra stamina
        if(CountdownManager.countdownOver == true){
            currentStamina -= Time.deltaTime * 3;
            sliderStamina.value = currentStamina / maxStamina;
            if (currentStamina <= 0){
                currentStamina = 0;
            }
        }
        
        //requerimentos pulo
        if(Input.GetButtonDown("Jump") && isGrounded && currentStamina >= 1 && CountdownManager.countdownOver == true)
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
        if (other.gameObject.CompareTag("Obstáculo") && isInCollision == false){
            isInCollision = true;
            currentStamina -= 10;
            SpawnObjectScript.velAtual -= 5f;
        }
        
        if (other.gameObject.CompareTag("LinhaChegada")){
            currentStamina = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        isInCollision = false;
    }
}
