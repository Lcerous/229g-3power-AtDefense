using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D.IK;

public class Goal : MonoBehaviour
{
    public GameObject lose;
    public CanonController canonController;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            //Add you lose UI
            //SceneManager.LoadScene("SampleScene");
            lose.SetActive(true);
            canonController.enabled = false;
            Cursor.visible = true;
            Time.timeScale = 0;
        }
    }
}
