using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    [SerializeField] private float destorytime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        SetDestoryTime();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetDestoryTime()
    {
        Destroy(gameObject, destorytime);
    }

    


}
