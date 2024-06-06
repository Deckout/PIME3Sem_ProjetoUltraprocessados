using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheatPress(){
        BarrasManager.currentEnergia = 100;
        BarrasManager.currentMentalidade = 100;
        BarrasManager.currentSaude = 100;
    }
}
