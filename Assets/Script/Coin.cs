using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public static bool setlife = false;

    private void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player")
        {
            Score.coinAmount += 1;
            Score.lifeAmount += 1;
            Destroy(gameObject);

            if(Score.lifeAmount == 30)
            {                             
                Life.life += 1;
                setlife = true;
                Score.lifeAmount = 0;            

            }
            else
            {
                setlife = false;
            }
            


            if (Score.coinAmount > HightScore.hightscore)
            {
                HightScore.hightscore = Score.coinAmount;
            }
        }       
    }
}
