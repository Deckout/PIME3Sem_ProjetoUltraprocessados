using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    //scroll speed added to all backgrounds
    public float additionalScrollSpeed;
    //an array of all the background game objects
    public GameObject[] backgrounds;
    //an array that corresponds to the backgrounds array, where it gives the scroll speed for each individual bg
    public float[] scrollSpeed;

    void Update()
    {
        if(CountdownManager.countdownOver == true && PlayerMovement.currentStamina > 0){
            //loops through array of object, making scrolling occur for each
            for (int background = 0; background < backgrounds.Length; background++)
            {
                //gets the renderer for this item in the array
                Renderer rend = backgrounds[background].GetComponent<Renderer>();
                //calculates the scroll offset
                float offset = Time.time * (scrollSpeed[background] + additionalScrollSpeed);
                //offets the texture of this item based on the offset calculated previously
                rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
            }       
        }
    }
}

