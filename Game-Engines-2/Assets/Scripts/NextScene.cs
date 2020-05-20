//Property of Dylan Gleeson
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextScene : MonoBehaviour
{

	#region Methods

	public void play()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}
    




	#endregion
}