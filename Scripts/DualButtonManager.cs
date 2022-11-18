using System;
using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class DualButtonManager : MonoBehaviour
{
    public bool bothPressed;
    public GameObject ButtonOne;
    public GameObject ButtonTwo;

    public GameObject Door;
    
    private bool soundPlayed;

    private void Update()
    {
        if (ButtonOne.gameObject.GetComponent<ButtonObject>().isPressed && ButtonTwo.GetComponent<ButtonObject>().isPressed)
        {
            bothPressed = true;
            Door.SetActive(false);
            
            if(!soundPlayed) 
            {
                FindObjectOfType<AudioManager>().Play("DoorOpen");
                soundPlayed = true;
            }
        }
        else
        {
            Door.SetActive(true);
            bothPressed = false;
            soundPlayed = false;
        }
    }
}
