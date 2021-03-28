using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    GameManager manager;
    _3Dcontrols control;
    bool isIn;

     void Awake()
    {
        control = new _3Dcontrols();
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        control.CharacterControls.Pickup.performed += ctx =>
        {
            if (isIn == true)

            {
                manager.CoinCount++;

                Destroy(gameObject);

            }
        };
    }


    void OnTriggerEnter(Collider other)
    {
        isIn = true;
    }
    public void OnTriggerExit(Collider other)
    {
        isIn = false;
    }
}
