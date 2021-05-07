using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Squid
{
    public class EnterUSBCColliderUI : MonoBehaviour
    {
        GameManager manager;
        public bool isIn;
        public GameObject UIshowup;
        _3Dcontrols control;

        // Start is called before the first frame update
        private void Awake()
        {
            control = new _3Dcontrols();
            //manager = GameObject.Find("GameManager").GetComponent<GameManager>();
            //control.CharacterControls.Pickup.performed += ctx =>
            //{
            //    Debug.LogWarning("E");
            //    if (isIn == true)
            //    {
            //        UIshowup.SetActive(true);
            //        Cursor.lockState = CursorLockMode.None;
            //    }
            //};
        }


        private void OnTriggerEnter(Collider other)
        {
            if (manager.Climber)
            {
                Debug.LogWarning("in");
                isIn = true;

            }
        }
        private void OnTriggerExit(Collider other)
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
