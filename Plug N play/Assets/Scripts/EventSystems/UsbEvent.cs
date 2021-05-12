using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UsbEvent : MonoBehaviour
{
    public static UsbEvent curr;
    // Start is called before the first frame update
    private void Awake()
    {
        curr = this;
    }

    public event Action TriggerEnterScene;
    public void triggerEnterScene()
    {
       if( TriggerEnterScene != null)
        {
            TriggerEnterScene();
        }

    }
}
