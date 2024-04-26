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

        EnemyUnit.Add(GameObject.FindGameObjectWithTag("Enemy"));

        if (enemyUnit.Count <= 0)
        {
            //Add you win UI
        }
        else
        {
            ListChecking();
        }
    }

    private void ListChecking()
    {
        foreach (GameObject n in EnemyUnit)
        {
            if (n == null)
            {
                EnemyUnit.Remove(n);
            }
        }
    }
    
}
