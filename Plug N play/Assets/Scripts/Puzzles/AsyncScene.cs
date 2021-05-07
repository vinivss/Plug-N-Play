using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Squid
{
    public class AsyncScene : MonoBehaviour
    {
        public Scene minigame;
        public string sceneName;
        public GameManager Manager;
        _3Dcontrols control;
        //public GameObject turnonnut;
        public GameObject E;
        bool isIn;
        bool load;
        public GameObject cont;



        void Awake()
        {

            minigame = SceneManager.GetSceneByPath(sceneName);
            Debug.Log(sceneName);
            control = new _3Dcontrols();
            Manager = GameObject.Find("GameManager").GetComponent<GameManager>();
            cont = GameObject.Find("Player1 1");
            control.CharacterControls.Pickup.performed += ctx =>
            {
                if (isIn == true)

                {
                    if (load != true)
                    {
                        sceneLoad();
                    }
                    if (load == true)
                    {
                        Cursor.lockState = CursorLockMode.None;
                        //Time.timeScale = 0;
                        cont.SetActive(false);
                       
                    }

                }
            };
        }

        public void becomeActive()
        {
            cont.SetActive(true);
        }
        private void Update()
        {
            if (isIn == true)
            {


                E.SetActive(true);
            }

            else
            {

                E.SetActive(false);
            }
        }

        void sceneLoad()
        {

            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
            load = true;
        }
        public void OnTriggerEnter(Collider other)
        {
            isIn = true;
        }

        public void OnTriggerExit(Collider other)
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