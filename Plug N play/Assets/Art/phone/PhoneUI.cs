using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Squid
{
    public class PhoneUI : MonoBehaviour
    {
        public GameObject lockscreen;
        public GameObject sslider;
        public Slider slider;
        public AsyncScene cont;
        public void Awake()
        {
            cont = GameObject.FindObjectOfType<AsyncScene>();
        }
        public void Unlock()
        {
            if (slider.value >= 1)
            {

                sslider.SetActive(false);
                lockscreen.SetActive(false);
            }

        }

        public void ExitOut()
        {
            sslider.SetActive(true);
            lockscreen.SetActive(true);

            SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Phone"));
            cont.becomeActive();
        }
    }
}