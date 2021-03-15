using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Jupiter
{
    public class SliderTrigger : MonoBehaviour
    {
        public GameManager Manager;
        _3Dcontrols control;
        public GameObject turnonnut;
        public bool isIn;

        private void Awake()
        {
            control = new _3Dcontrols();
            Manager = GameObject.Find("GameManager").GetComponent<GameManager>();
            control.CharacterControls.Pickup.performed += ctx =>
            {
                if (isIn == true)
                {
                    turnonnut.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                }
            };
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
}
