using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VideoTime : MonoBehaviour
{
    //[SerializeField] private GameObject gameObject;
    [SerializeField] private float remainingTime;
    float timeStart;

    private void Start()
    {
        timeStart = remainingTime;
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
        }
    }
}
