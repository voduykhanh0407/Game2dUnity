using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class dontdestroy : MonoBehaviour
{
    private static bool playerExists;
    // Start is called before the first frame update
    void Start()
    {
        
        if (!playerExists)
        {
            playerExists = true;
            DontDestroyOnLoad(transform.gameObject);
        } else
        {
            Destroy (gameObject);
        }
    }
}
   
