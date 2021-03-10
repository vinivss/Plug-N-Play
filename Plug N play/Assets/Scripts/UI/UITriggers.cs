using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

namespace Jupiter
{
    public class UITriggers : MonoBehaviour
    {
        //public PathCreator RedCar;

       public Racered redcar;
       GameManager gameManager;
       public GameObject MaximumOverdrive;


        void Awake()
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
       public  void ButtonPress()
        {
            gameManager.CarReady = true;
            Destroy(MaximumOverdrive);
        }

    }
}
