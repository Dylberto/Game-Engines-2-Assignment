//Property of Dylan Gleeson
using System;
using System.Collections;
using UnityEngine;
using UnityStandardAssets.Effects;

public class ExpressMove : MonoBehaviour
{
    #region Variables

    public GameObject[] waypoints;
    public static int current_waypoint = 0;
    public float spd = 10f;
    public float rot_spd = 1f;
    public float range = 5f;
    public float rot_clamp = 0.5f;
    private bool start = false;
    public GameObject bullet;
    public bool fired = false;

    #endregion


    #region Methods

    void Start()
    {
        StartCoroutine(go());
        current_waypoint = 0;
    }

    void Update()
    {
        if (Vector3.Distance(waypoints[current_waypoint].transform.position, transform.position) < range)
        {
            if (current_waypoint < waypoints.Length)
            {
                current_waypoint++;
            }
            else
            {
                return;
            }

        }

        if(start == true)
        {
            transform.position += transform.forward * spd * Time.deltaTime;


            //rotation
            Vector3 pos = waypoints[current_waypoint].transform.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(pos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rot_clamp * Time.deltaTime);
        }

        if(current_waypoint >= 11)
        {
            if(fired == false)
            {
                StartCoroutine(fire());
            }
            
        }
    }


    IEnumerator go()
    {
        yield return new WaitForSeconds(8);

        start = true;

    }

    IEnumerator fire()
    {
        fired = true;

        Instantiate(bullet, transform.position, transform.rotation);

        yield return new WaitForSeconds(100);

    }

    #endregion

}