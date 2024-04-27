using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] private List<GameObject> enemyUnit = new List<GameObject>();
    public List<GameObject> EnemyUnit { get { return enemyUnit; } }



    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

        //EnemyUnit.Add(GameObject.FindGameObjectWithTag("Enemy"));

        
        ListChecking();
        
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
                }
            }
        }
        else
        {
            // Change to win Scence
            SceneManager.LoadScene("SampleScene");
        }


    }


    
}
