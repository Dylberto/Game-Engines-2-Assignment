//Property of Dylan Gleeson
using System;
using System.Collections;
using UnityEngine;

public class Cam_manager : MonoBehaviour
{
    #region Variables

    public GameObject start_view;
    public GameObject front_view;
    public GameObject flip_view;
    public GameObject close_up;
   

    #endregion


    #region Methods
    void Start()
    {
        start_view.SetActive(true);
        front_view.SetActive(false);
        flip_view.SetActive(false);
        close_up.SetActive(false);
    }

    
    void Update()
    {
        if(ExpressMove.current_waypoint >= 2)
        {
            start_view.SetActive(false);
            front_view.SetActive(true);
        }

        if (ExpressMove.current_waypoint >= 6)
        {
            front_view.SetActive(false);
            flip_view.SetActive(true);
        }

        if (ExpressMove.current_waypoint >= 11)
        {
            flip_view.SetActive(false);
            close_up.SetActive(true);
        }

       


    }




	#endregion
}