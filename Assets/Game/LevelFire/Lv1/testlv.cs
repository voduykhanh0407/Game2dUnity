using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testlv : MonoBehaviour
{

    public GameObject a;
    public float TimeToHide;
    private float TimeCR;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (TimeToHide <= 0)
        {
            a.SetActive(false);
        }
        else
        {
            TimeToHide -= Time.deltaTime;
        }
    }
}
