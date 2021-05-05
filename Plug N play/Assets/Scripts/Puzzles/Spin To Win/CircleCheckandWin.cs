using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Squid
{


    public class CircleCheckandWin : MonoBehaviour
    {
        GameManager manager;
        public GameObject WinScreen;
        float winTime = 5.0f;
        public List<GameObject>  checkpoints;
        int i = 0;
        int sizeofList;
        [SerializeField] int Touch;
        public bool hasWon = false;
        float winTimer = 5.0f;
        private void Awake()
        {
            //manager = GameObject.Find("GameManager").GetComponent<GameManager>();
            //Time.timeScale = 0.0f;
            foreach (GameObject GO in checkpoints)
            {
                GO.GetComponent<ChildCollide>().ChildTouch.AddListener(EnterColl);
            }
            sizeofList = checkpoints.Count;
        }
        private void Update()
        {
            if (hasWon == true)
            {
                winTimer -= Time.fixedDeltaTime;
            }
        }
        public void EnterColl()
        {
            if (Touch < checkpoints.Count)
            {
                Debug.Log("In");
                Touch++;
                checkpoints[i].SetActive(false);
                if(i != checkpoints.Count)
                i += 1;
                if (i < sizeofList)
                {
                    checkpoints[i].SetActive(true);
                }
                else
                {
                    Win();
                }
            }
           

        }

        public void Win()
        {

            //WinScreen.SetActive(true);
            Debug.Log("WIN");


            Cursor.lockState = CursorLockMode.Locked;

            manager.FerrisWheel = true;

            SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Spin"));
        } 
    }
}
