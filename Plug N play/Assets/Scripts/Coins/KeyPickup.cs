using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    GameManager manager;
    _3Dcontrols control;
    public GameObject particle;
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
                Debug.Log(manager.CoinCount);
                particle.SetActive(true);
                DestroyImmediate(gameObject);

            }
        };
    }


    void OnTriggerEnter(Collider other)
    {
        isIn = true;
        Debug.Log("Is  in");
    }
    public void OnTriggerExit(Collider other)
    {
        isIn = false;
    }
    void OnEnable()
    {
        control.CharacterControls.Enable();
        control.CameraControls.Enable();
    }

    void OnDisable()
    {

        control.CharacterControls.Disable();
        control.CameraControls.Disable();
    }
}
