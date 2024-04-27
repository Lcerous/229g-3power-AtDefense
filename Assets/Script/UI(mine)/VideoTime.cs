using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;
using static System.Net.WebRequestMethods;

public class VideoTime : MonoBehaviour
{
    [SerializeField] private GameObject canvas;

    //[SerializeField] private GameObject gameObject;
    [SerializeField] private float remainingTime;
    float timeStart;

    VideoPlayer videoPlayer;

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        timeStart = remainingTime;
        videoPlayer.url = "https://wasintamp1.github.io/avideo/0323.mp4";
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else
        {
            this.gameObject.SetActive(false);
            remainingTime = timeStart;
            canvas.SetActive(true);
            this.enabled = false;
        }
    }
}
