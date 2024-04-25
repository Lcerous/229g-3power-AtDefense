using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    private Rigidbody2D rb;
    private float velocity;
    [SerializeField] private float acc;
    [SerializeField] private float destorytime = 3f;
    private float mass;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mass = rb.mass;
        velocity = mass * acc;

        SetStraightVelocity();
        SetDestoryTime();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetStraightVelocity()
    {
        rb.velocity = transform.right * velocity;
    }

    private void SetDestoryTime()
    {
        Destroy(gameObject, destorytime);
    }
}
