using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using UnityEngine.UI;

namespace Jupiter
{
    public class UITriggers : MonoBehaviour
    {
        //public PathCreator RedCar;

       public Racered redcar;
       GameManager gameManager;
       public GameObject MaximumOverdrive;
        public Slider slider;
        public GameObject Slider;


        void Awake()
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
       public  void ButtonPress()
        {
            gameManager.CarReady = true;
            Destroy(MaximumOverdrive);
            Cursor.lockState = CursorLockMode.Locked;
        }

        public void SliderTrue()
        {
            if (slider.value == 10)
            {

                gameManager.BlueCarMove = true;
                Destroy(Slider);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}
