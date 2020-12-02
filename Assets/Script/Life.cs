using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    Text heart;

    public static double life;
    // Start is called before the first frame update
    void Start()
    {
        
        heart = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        heart.text = life.ToString();

    }
}