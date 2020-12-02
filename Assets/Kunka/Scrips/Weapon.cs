using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject ButtletPrefab;
    private float TimeBtwShots;
    public float StartTimeShots;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeBtwShots <= 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
            TimeBtwShots = StartTimeShots;
        }
        else
            TimeBtwShots -= Time.deltaTime;
    }

    void Shoot()
    {
        Instantiate(ButtletPrefab, FirePoint.position, FirePoint.rotation);
    }
}
