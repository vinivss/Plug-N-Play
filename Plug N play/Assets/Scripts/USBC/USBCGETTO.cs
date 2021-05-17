using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 namespace Jupiter
{
    public class USBCGETTO : MonoBehaviour
    {
        _3Dcontrols controls;
        GameManager Manager;
        public bool isIn;
        public GameObject Poof;
      
        public TotemState Totem;
        public void Awake()
        {
            controls = new _3Dcontrols();

            Manager = GameObject.Find("GameManager").GetComponent<GameManager>();
            

            controls.CharacterControls.Pickup.performed += ctx =>
            {
                if (isIn == true)
                {
                    Poof.SetActive(true);
                    Manager.USBmini = true;
                    Totem.ChangeStateUSBC();
                   
                    Destroy(gameObject);



                }
            };
        }
        public void OnTriggerEnter(Collider other)
        {
            isIn = true;

            Debug.Log("in");



        }
        public void Update()
        {

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
}
