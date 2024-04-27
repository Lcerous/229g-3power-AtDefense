using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject video;

    [SerializeField] private VideoTime videoTime;

    public void BtnPlay() // click and load new scene
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void BtnQuit() // click and quit game
    {
        Application.Quit();
    }

    public void BtnCredits() //play video credits
    {
        video.SetActive(true);
        videoTime.enabled = true;

        this.gameObject.SetActive(false);
    }
}
