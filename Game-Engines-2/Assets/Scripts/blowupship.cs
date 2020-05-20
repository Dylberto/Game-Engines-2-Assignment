//Property of Dylan Gleeson
using System;
using System.Collections;
using UnityEngine;

public class blowupship : MonoBehaviour
{
    #region Variables
    public Transform ship_2;
    public Transform ship_1;
    public GameObject exress_bullet;
    public Transform waypoint;
    public GameObject explosion;
    public float range = 20;
    private bool ship_2_alive = true;
    private bool ship_1_alive = true;
    #endregion


    #region Methods


    void Update()
    {
        if(ship_2_alive == true)
        {
            if (Vector3.Distance(ship_2.transform.position, waypoint.position) < range)
            {
                Destroy(ship_2.gameObject);
                Instantiate(explosion, waypoint.position, waypoint.rotation);
                ship_2_alive = false;
            }
        }
      


        if(Vector3.Distance(exress_bullet.transform.position, ship_1.position) < range)
        {
            Destroy(ship_1.gameObject);
            Destroy(exress_bullet.gameObject);
            Instantiate(explosion, ship_1.position, waypoint.rotation);
            ship_1_alive = false;
        }

    }




	#endregion
}