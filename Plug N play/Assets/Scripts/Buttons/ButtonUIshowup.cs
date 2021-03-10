using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class ButtonUIshowup : MonoBehaviour
{
    public GameManager Manager;
    _3Dcontrols control;
    public GameObject turnonnut;

    bool isIn;

    void Awake()
    {
        control = new _3Dcontrols();
        Manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        control.CharacterControls.Pickup.performed += ctx =>
        {
            if (isIn == true)
            {
                turnonnut.SetActive(true);
            }
        };
    }
     void Update()
    {
       
    }
    public void OnTriggerEnter(Collider other)
    {
        isIn = true;
    }

    public void OnTriggerExit(Collider other)
    {
        isIn = false;
    }
    private void OnEnable()
    {
        control.CharacterControls.Enable();
    }

    private void OnDisable()
    {
        control.CharacterControls.Disable();
    }
}
