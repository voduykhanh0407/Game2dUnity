using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HightScore : MonoBehaviour
{

    Text highttext;
    public static int hightscore = 0;
    // Start is called before the first frame update
    void Start()
    {
        highttext = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        highttext.text = hightscore.ToString();
    }
}
