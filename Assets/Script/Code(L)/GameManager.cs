using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class GameManager : MonoBehaviour
{
    public float timeWin;
    bool win = false;
    public GameObject textWin;

    bool playVideo = false;

    [SerializeField] private List<GameObject> enemyUnit = new List<GameObject>();
    public List<GameObject> EnemyUnit { get { return enemyUnit; } }

    float score = 0;
    public Text textScore;

    public GameObject video;
    public VideoTime videoTime;



    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        textScore.text = string.Format("Enemy Destroyed: {0}", score);
    }

    // Update is called once per frame
    void Update()
    {

        //EnemyUnit.Add(GameObject.FindGameObjectWithTag("Enemy"));
        ListChecking();
        if (textWin.active == true)
        {
            if (timeWin > 0)
            {
                timeWin -= Time.deltaTime;
            }
            else
            {
                win = true;
            }
        }
        
        
    }

    private void ListChecking()
    {
        if (enemyUnit.Count > 0)
        {
            foreach (GameObject n in EnemyUnit)
            {
                if (n == null)
                {
                    EnemyUnit.Remove(n);
                    score += 1;
                    textScore.text = string.Format("Enemy Destroyed: {0}", score);
                }
            }
        }
        else
        {
            if (win == false)
            {
                textWin.SetActive(true);
                Cursor.visible = true;
            }
            else
            {
                video.SetActive(true);
                videoTime.enabled = true;
            }
        }


    }


    
}
