using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aniforlife : MonoBehaviour
{
    public Animator cherry;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Coin.setlife == true)
        {
            cherry.SetBool("SetLife", true);
           
        }
        
        else
        {
            cherry.SetBool("SetLife", false);
        }
    } 
    
}
