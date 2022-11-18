using System;
using UnityEngine;

namespace StarterAssets
{
    public class ButtonObject : MonoBehaviour
    {
        public bool isPressed;
        bool played;

        private void OnTriggerEnter(Collider collision)
        {
            if (collision.gameObject.CompareTag("Moveable"))
            {
                isPressed = true;
                if (!played)
                {
                    FindObjectOfType<AudioManager>().Play("ButtonPressed");
                    played = !played;
                }
                
            }
               
        }

        private void OnTriggerStay(Collider collisionInfo)
        {
            if (collisionInfo.gameObject.CompareTag("Moveable")) 
                isPressed = true;
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Moveable"))
            {
                isPressed = false;
                if (played)
                    played = false;
            }
                
        }
    }
}