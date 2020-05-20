//Property of Dylan Gleeson
using System;
using System.Collections;
using UnityEngine;

public class attck : MonoBehaviour
{
    #region Variables
    public Transform target;
    public float spd = 300;

    #endregion


    #region Methods
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Ship").transform;
      
    }


    void Update()
    {
        transform.LookAt(target.position);
        transform.position += transform.forward * spd * Time.deltaTime;
    }


	#endregion
}