using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        enPiano piano;

        public void Awake()
        {
            
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

        public void Cplay()
        {
            c.Play();
            piano = enPiano.C;
        }

        public void Dplay()
        {
            d.Play();
            piano = enPiano.D;
        }
        public void Eplay()
        {
            e.Play();
            piano = enPiano.E;
        }
        public void Fplay()
        {
            f.Play();
            piano = enPiano.F;
        }
        public void Gplay()
        {
            g.Play();
            piano = enPiano.G;
        }
        public void Aplay()
        {
            a.Play();
            piano = enPiano.A;
        }
        public void Bplay()
        {
            b.Play();
            piano = enPiano.B;
        }
        public void C1play()
        {
            c1.Play();
            piano = enPiano.C1;
        }
      
        public void D1()
        {
            d1.Play();
            piano = enPiano.D1;
        }
        public void E1play()
        {
            e1.Play();
            piano = enPiano.E1;
        }
        public void F1play()
        {
            f1.Play();
            piano = enPiano.F1;
        }
        public void Csplay()
        {
            cs.Play();
            piano = enPiano.CS;
        }
        public void Dsplay()
        {
            d.Play();
            piano = enPiano.DS;
        }
        public void Fsplay()
        {
            fs.Play();
            piano = enPiano.FS;
        }
        public void Gsplay()
        {
            gs.Play();
            piano = enPiano.GS;
        }
        public void bbplay()
        {
            bb.Play();
            piano = enPiano.Bb;
        }
        public void Cs1play()
        {
            cs1.Play();
            piano = enPiano.CS1;
        }
        public void Ds1play()
        {
            ds1.Play();
            piano = enPiano.DS1;
        }

    }
}
