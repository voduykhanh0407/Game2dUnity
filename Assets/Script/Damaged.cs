using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaged : MonoBehaviour
{

    public GameObject player;
    public string gameover;
    public bool hurt = false;
    public Animator Hurter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {           
            Hurter.SetTrigger("IsHurting");
            StartCoroutine("Hurt");

            if (Life.life == 0)
            {
                if (gameObject.tag == "Player")
                {
                    Application.LoadLevel(gameover);
                    Money.money += Score.coinAmount;
                }
                //Destroy(player);
                
            }
            else if (Life.life > 0)
            {
                Life.life -= 1;

            }
                   
        }
    }

    IEnumerator Hurt()
    {
        hurt = true;

        yield return new WaitForSeconds(0.5f);
        hurt = false;
    }
    
}
