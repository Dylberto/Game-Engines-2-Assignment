//Property of Dylan Gleeson
using System;
using System.Collections;
using UnityEngine;

public class Laser : MonoBehaviour
{
    #region Variables
    public Transform target;
    public float spd = 300;

	#endregion


	#region Methods
	void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        transform.LookAt(target.position);
        StartCoroutine(destroy());
    }

    
    void Update()
    {
     
      
        transform.position += transform.forward * spd * Time.deltaTime;

    }

    IEnumerator destroy()
    {
        yield return new WaitForSeconds(10);

        Destroy(gameObject);
    }


	#endregion
}