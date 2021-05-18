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
        public GameObject CamUSB;
        public GameObject CamCar;
        public GameObject Buttoff;
        public GameObject Cat;
        public GameObject EasterButt;


        void Awake()
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
       public  void ButtonPress()
        {
            //Debug.LogAssertionFormat("CameraCalledProperly");
            CamUSB.SetActive(false);
            CamCar.SetActive(true);
            gameManager.BlueCarMove = true;
            Destroy(MaximumOverdrive);
            Cursor.lockState = CursorLockMode.Locked;
        }
        public void ButtonPressCat()
        {

          
            gameManager.FireTruck = true;
            Destroy(Cat);
            Cursor.lockState = CursorLockMode.Locked;
        }

        public void SliderTrue()
        {
            if (slider.value == 10)
            {
               
                gameManager.CarReady = true;
                Destroy(Slider);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }

        public void Roomba()
        {
            //gameManager.RoombaReady = true;
            //Destroy(Buttoff);
            Cursor.lockState = CursorLockMode.Locked;
        }

        public void DS()
        {
            gameManager.DSEject = true;
            Destroy(Buttoff);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
