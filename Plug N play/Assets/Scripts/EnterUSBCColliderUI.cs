using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class EnterUSBCColliderUI : MonoBehaviour
    {
        GameManager manager;
        public bool In = false;
        public GameObject UIshowup;
        _3Dcontrols control;

        // Start is called before the first frame update
        private void Awake()
        {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        control = new _3Dcontrols();
         
              
             control.CharacterControls.Pickup.performed += ctx =>
                {
                    if (In == true)
                    {
                        UIshowup.SetActive(true);
                        Cursor.lockState = CursorLockMode.None;
                    }

                };
            
        }

    public void Update()
    {
        Debug.Log("isin " +  In);
                
    }
    private void OnTriggerEnter(Collider other)
        {
        if (other.gameObject.CompareTag("Player"))
            {
            if (manager.Climber)
            {
                Debug.LogWarning("in");
                In = true;

            }
        }
        }
        private void OnTriggerExit(Collider other)
        {
        if (other.gameObject.CompareTag("Player"))
        {
            In = false;
        }
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
