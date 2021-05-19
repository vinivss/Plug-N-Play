using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudAnim : MonoBehaviour
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
        if (manager.Climber)
        {
            anim.SetBool("Climber", true);
        }

        if (manager.USBmini)
        {
            anim.SetBool("USBc", true);
        }
    }
}
