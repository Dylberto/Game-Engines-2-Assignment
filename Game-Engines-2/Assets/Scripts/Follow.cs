//Property of Dylan Gleeson
using System;
using System.Collections;
using UnityEngine;

public class Follow : MonoBehaviour
{
    #region Variables

    public GameObject[] waypoints;
    public int current_waypoint = 0;
    public Transform target;
    public float spd = 50f;
    public float rot_spd = 1f;
    public float range = 10f;
    public float rot_clamp = 1f;
    private bool start = false;
 

    #endregion


    #region Methods

    void Start()
    {
        StartCoroutine(go());
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {

		#region movement

		if (Vector3.Distance(waypoints[current_waypoint].transform.position, transform.position) < range)
        {
            if(current_waypoint < waypoints.Length)
            {
                current_waypoint++;
            }
            else
            {
                return;
            }

        }

        if (start == true)
        {
            transform.position += transform.forward * spd * Time.deltaTime;


            Vector3 pos = waypoints[current_waypoint].transform.position - transform.position;
           
            Quaternion rotation = Quaternion.LookRotation(pos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rot_clamp * Time.deltaTime);
        }

		#endregion


	
	}


	IEnumerator go()
    {
        yield return new WaitForSeconds(8);

        start = true;

    }

    #endregion
}