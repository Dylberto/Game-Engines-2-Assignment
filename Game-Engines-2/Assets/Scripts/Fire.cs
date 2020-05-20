//Property of Dylan Gleeson
using System.Collections;
using UnityEngine;

public class Fire : MonoBehaviour
{
    #region Variables

    private bool start = false;
    public GameObject bullet;
    private bool fired = false;

    #endregion


    #region Methods
    void Start()
    {
        StartCoroutine(go());
    }

    
    void Update()
    {
        

        if (start == true)
        {
            if (fired == false)
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
        float cooldown = Random.Range(0.5f, 4f);

        yield return new WaitForSeconds(cooldown);

        fired = false;
    }



    #endregion
}