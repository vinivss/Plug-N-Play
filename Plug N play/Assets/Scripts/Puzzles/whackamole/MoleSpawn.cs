using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Squid
{
    public class MoleSpawn : MonoBehaviour
    {
        public GameObject DustBunnyP;
        public GameObject Canvas;
        public Transform[] spawnLoc;
        private Vector3 spawntrans;
        Button Butt;
        public GameObject spwnButt;
        bool win = false;
        public float TimeSaved;
        float timer;
        private int Scre = 0;
        GameManager manager;
        public GameObject WinScreen;
        float winTime = 5.0f;
        public AsyncScene cont;
        bool start = false;
        // Start is called before the first frame update
        void Start()
        {
            manager = GameObject.Find("GameManager").GetComponent<GameManager>();
            cont = GameObject.FindObjectOfType<AsyncScene>();
            Cursor.lockState = CursorLockMode.None;
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("Whackamole"));

        }

        // Update is called once per frame

        public void firstClick()
        {
            DestroyImmediate(spwnButt);
            start = true;
            
            Spawn();
            timer = TimeSaved;
        }
        void Update()
        {
            if (start)
            {
                Debug.LogError("called");
                timer -= 0.5f;
            }
            if (timer <= 0.0f)
            {
                Demolish();
            }
            if(win == true)
            {

                winTime = winTime - Time.fixedDeltaTime;
                if (winTime <= 0.0f)
                    Win();
            }
        }
        public void Spawn()
        {
            Debug.Log("asadas");
            if(Butt != null)
            {
                Debug.Log("Butt Null");
                Butt = null;
            }

            if (win != true)
            {

                spawntrans = spawnLoc[Random.Range(0, spawnLoc.Length)].transform.position;
                GameObject DustBunny = Instantiate(DustBunnyP, spawntrans, Quaternion.identity, Canvas.transform) as GameObject;
                Butt = GetComponentInChildren<Button>();
                Butt.onClick.AddListener(Score);



            }




        }
        public void Score()
        {
          
            Scre++;
            var child = transform.GetChild(0);
            //Destroy(child.gameObject);
            DestroyImmediate(Butt.gameObject);

            if (Scre < 5)
            {
                
                Spawn();
            }
            else if(Scre >= 5)
            {
                win = true;
                Win();
            }



        }

        public void Demolish()
        {
            if (start)
            {
                if (Butt != null)
                {
                    DestroyImmediate(Butt.gameObject);
                }
                timer = TimeSaved;
                Spawn();
            }
        }

        public void Win()
        {

            cont.becomeActive();
            
            WinScreen.SetActive(true);
            
               
            
            if (winTime <= 0.0f)
            {
                Cursor.lockState = CursorLockMode.Locked;

                manager.RoombaReady = true;

                SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Whackamole"));
            }
        }
    }
}
