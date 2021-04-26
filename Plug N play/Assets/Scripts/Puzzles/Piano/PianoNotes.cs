using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Squid
{
   public enum enPiano { C,D,E,F,G,A,B,C1,D1,E1,F1,CS,DS,FS,GS,Bb,CS1,DS1};
    public class PianoNotes : MonoBehaviour
    {
        public AudioSource c;
        public AudioSource d;
        public AudioSource e;
        public AudioSource f;
        public AudioSource g;
        public AudioSource a;
        public AudioSource b;
        public AudioSource c1;
        public AudioSource d1;
        public AudioSource e1;
        public AudioSource f1;
        public AudioSource cs;
        public AudioSource ds;
        public AudioSource fs;
        public AudioSource gs;
        public AudioSource bb;
        public AudioSource cs1;
        public AudioSource ds1;
        public int noteGuess;
        public int timeskeypress;
        bool win = false;
        public GameObject WinScreen;
        float winTime = 5.0f;
        GameManager manager;
        enPiano piano;

        public void Start()
        {
            manager = GameObject.Find("GameManager").GetComponent<GameManager>();
            Cursor.lockState = CursorLockMode.None;
        }
        public void playPiano(enPiano note)
        {

            switch (note)
            {
                case enPiano.C:
                    {
                        Debug.Log("C");
                        break;

                    }
                case enPiano.D:
                    {
                        Debug.Log("D");
                        break;

                    }
                case enPiano.E:
                    {
                        Debug.Log("E");
                        break;

                    }
                case enPiano.F:
                    {
                        Debug.Log("F");
                        break;

                    }
                case enPiano.G:
                    {
                        Debug.Log("G");
                        break;

                    }
                case enPiano.A:
                    {
                        Debug.Log("A");
                        break;

                    }
                case enPiano.B:
                    {
                        Debug.Log("B");
                        break;

                    }
                case enPiano.C1:
                    {
                        Debug.Log("C1"); ;
                        break;

                    }
                case enPiano.D1:
                    {
                        Debug.Log("D1");
                        break;

                    }
                case enPiano.E1:
                    {
                        Debug.Log("E1");
                        break;

                    }
                case enPiano.F1:
                    {
                        Debug.Log("F1");
                        break;

                    }
                case enPiano.CS:
                    {
                        Debug.Log("CS");
                        break;

                    }
                case enPiano.DS:
                    {
                        Debug.Log("DS");
                        break;

                    }
                case enPiano.FS:
                    {
                        Debug.Log("Fs");
                        break;

                    }
                case enPiano.GS:
                    {
                        Debug.Log("GS");
                        break;

                    }
                case enPiano.Bb:
                    {
                        Debug.Log("Bb");
                        break;

                    }
                case enPiano.CS1:
                    {
                        Debug.Log("CS1");
                        break;

                    }
                case enPiano.DS1:
                    {
                        Debug.Log("DS1");
                        break;

                    }
            }
        }

        public void Win()
        {
            Time.timeScale = 1.0f;

            WinScreen.SetActive(true);



            if (winTime <= 0.0f)
            {
                Cursor.lockState = CursorLockMode.Locked;

                manager.RoombaReady = true;

                SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Piano"));
            }
        }
        public void Cplay()
        {
            c.Play();
            playPiano(enPiano.C);
        }

        public void Dplay()
        {
            d.Play();
            playPiano(enPiano.D);
        }
        public void Eplay()
        {
            e.Play();
            playPiano(enPiano.E);
        }
        public void Fplay()
        {
            f.Play();
            playPiano(enPiano.F);
        }
        public void Gplay()
        {
            g.Play();
            playPiano(enPiano.G); 
        }
        public void Aplay()
        {
            a.Play();
            playPiano(enPiano.A);
        }
        public void Bplay()
        {
            b.Play();
            playPiano(enPiano.B);
        }
        public void C1play()
        {
            c1.Play();
            playPiano(enPiano.C1);
        }
      
        public void D1()
        {
            d1.Play();
            playPiano(enPiano.D1);
        }
        public void E1play()
        {
            e1.Play();
            playPiano(enPiano.E1);
        }
        public void F1play()
        {
            f1.Play();
            playPiano(enPiano.F1);
        }
        public void Csplay()
        {
            cs.Play();
            playPiano(enPiano.CS);
        }
        public void Dsplay()
        {
            ds.Play();
            playPiano(enPiano.DS);
        }
        public void Fsplay()
        {
            fs.Play();
            playPiano(enPiano.FS);
        }
        public void Gsplay()
        {
            gs.Play();
            playPiano(enPiano.GS);
        }
        public void bbplay()
        {
            bb.Play();
            playPiano(enPiano.Bb);
        }
        public void Cs1play()
        {
            cs1.Play();
            playPiano(enPiano.CS1);
        }
        public void Ds1play()
        {
            ds1.Play();
            playPiano(enPiano.DS1);
        }

    }
}
