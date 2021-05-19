using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HOFTransfer : MonoBehaviour
{
    GameManager manager;
    public bool In = false;
 
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

                SceneManager.LoadScene("Hall of Fame");
               
            }

        };

    }

    public void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (manager.Climber && manager.USBmini)
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


