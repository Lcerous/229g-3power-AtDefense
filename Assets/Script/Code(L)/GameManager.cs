using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] private List<GameObject> enemyUnit = new List<GameObject>();
    public List<GameObject> EnemyUnit { get { return enemyUnit; } }

    
    void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyUnit.Add(GameObject.FindGameObjectWithTag("Enemy"));

        if (enemyUnit.Count <= 0)
        {
            SceneManager.LoadScene("SampleScene");
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
