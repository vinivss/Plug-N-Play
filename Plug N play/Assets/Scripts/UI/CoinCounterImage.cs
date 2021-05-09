using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounterImage : MonoBehaviour
{
    GameManager manager;
    public Sprite[] sprites;
    public Image spriteRenderer;
    // Start is called before the first frame update
    void Awake()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(manager.CoinCount == 0)
        {
            spriteRenderer.sprite = sprites[0];
        }
        else if (manager.CoinCount == 1)
        {
            spriteRenderer.sprite = sprites[1];
        }
        else if (manager.CoinCount == 2)
        {
            spriteRenderer.sprite = sprites[2];
        }
        else if (manager.CoinCount == 3)
        {
            spriteRenderer.sprite = sprites[3];
        }
        else if (manager.CoinCount == 4)
        {
            spriteRenderer.sprite = sprites[4];
        }
        else if (manager.CoinCount == 5)
        {
            spriteRenderer.sprite = sprites[5];
        }
    }
}
