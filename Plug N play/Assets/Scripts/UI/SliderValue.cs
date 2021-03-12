using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Jupiter
{
    public class SliderValue : MonoBehaviour
    {
        GameManager manager;
        public Slider Slider;
        UITriggers Bluecar;
        // Start is called before the first frame update
        private void Awake()
        {
            manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }

        // Update is called once per frame
        void Update()
        {
          


        }
    }
}
