using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Power : MonoBehaviour
{
    public float a, b;
    public string gameover;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Power")
        {
            
            if(Life.life == 0)
            {
                if (gameObject.tag == "Player")
                {
                    Application.LoadLevel(gameover);
                }
                //Destroy(player);

            }
            else if (Life.life > 0)
            {
                Life.life -= 1;
                gameObject.transform.position = new Vector2(a, b);
            }

        }
    }
}
