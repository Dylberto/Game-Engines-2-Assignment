//Property of Dylan Gleeson
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class video : MonoBehaviour
{
    #region Variables
    public GameObject raw_image;
    public RawImage image;
    public VideoPlayer player;
    public AudioSource audio_source;
    private bool played = false;

	#endregion


	#region Methods
	void Start()
    {
        raw_image.SetActive(true);
        StartCoroutine(play_video());
        player = this.GetComponent<VideoPlayer>();
        audio_source = this.GetComponent<AudioSource>();
    }

    
    IEnumerator play_video()
    {
        player.Prepare();
        yield return new WaitForSeconds(0.1f);
        while (!player.isPrepared)
        {
            yield return new WaitForSeconds(0.1f);
            break;
        }
        

        image.texture = player.texture;
        player.Play();
        audio_source.Play();
        played = true;
        yield return new WaitForSeconds(8);

        image.enabled = false;

        yield return new WaitForSeconds(18.5f);

        image.enabled = true;


    }


    void Update()
    {
        if (!player.isPlaying && played == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        }
    }






    #endregion
}