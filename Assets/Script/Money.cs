using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public static int money = 0;
    Text highttext;
    // Start is called before the first frame update
    void Start()
    {
        highttext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        highttext.text = money.ToString();
    }
}
