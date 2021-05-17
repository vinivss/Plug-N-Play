using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USBANIm : MonoBehaviour
{
    public Animator anim;
    public GameManager manager;

    private void Awake()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if(manager.Climber)
        {
            anim.SetBool("Climber-kun", true);
        }

        if(manager.USBmini)
        {
            anim.SetBool("Type C san", true);
        }
    }
}
