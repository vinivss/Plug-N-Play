using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gacha : MonoBehaviour
{
    GameManager manager;
    _3Dcontrols control;
    public bool GIn = false;
    public Animator anim;
    public GameObject E;
    // Start is called before the first frame update
    void Awake()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        control = new _3Dcontrols();


        control.CharacterControls.Pickup.performed += ctx =>
        {
            if (GIn == true && manager.CoinCount == 5)
            {
                manager.CoinCount = 0;
                anim.Play("gachapon activating");
            }

        };
    }
    private void Update()
    {
        if (GIn == true)
        {
            E.SetActive(true);
        }

        else
        {
            E.SetActive(false);
        }
    }
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
 
                Debug.LogWarning("in");
                GIn = true;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GIn = false;
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
