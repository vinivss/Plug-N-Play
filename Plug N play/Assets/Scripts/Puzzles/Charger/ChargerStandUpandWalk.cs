using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargerStandUpandWalk : MonoBehaviour
{
    public GameObject Charger;
    public GameObject Walk;
    public GameObject WalkCam;
    public GameManager manager;
    public GameObject plugyou;
    public GameObject plugme;
    public GameObject usbChan;
    _3Dcontrols controls;
    bool isIn = false;
    private void Awake()
    {
        controls = new _3Dcontrols();
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        controls.CharacterControls.Pickup.performed += ctx =>
        {
            if (isIn == true)
            {
                Charger.SetActive(false);
                plugme.SetActive(false);
                usbChan.SetActive(false);
                Walk.SetActive(true);
                WalkCam.SetActive(true);
                



            }
        };
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!manager.Climber)
            {
                plugyou.SetActive(true);

            }
            else if(manager.Climber)
            {
                plugme.SetActive(true);
                isIn = true;
            }
        }    
    }

    public void OnTriggerExit(Collider other)
    {
            plugme.SetActive(false);


        

       
            plugyou.SetActive(false);
        
    }
    private void OnEnable()
    {
        controls.CharacterControls.Enable();
    }

    private void OnDisable()
    {
        controls.CharacterControls.Disable();
    }
}
