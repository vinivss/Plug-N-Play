using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jupiter
{
    public class Debugline : MonoBehaviour
    {
        public int maxRenderers;

        List<LineRenderer> lines = new List<LineRenderer>();

         void Start()
        {
            for (int i = 0; i < maxRenderers; i++) 
            {
                CreateLine(i);
            }
        }

        void CreateLine(int i)
        {
            GameObject go = new GameObject();
            lines.Add(go.AddComponent<LineRenderer>());
            lines[i].widthMultiplier = 0.05f;
        }
        public void SetLine(Vector3 startpos, Vector3 endpos, int index)
        {
            if (index > lines.Count - 1)
                CreateLine(index);
            lines[index].SetPosition(0, startpos);
            lines[index].SetPosition(1, endpos);
           
        }

        public static Debugline singleton;
        void Awake()
        {
            singleton = this;
        }

    }
}
