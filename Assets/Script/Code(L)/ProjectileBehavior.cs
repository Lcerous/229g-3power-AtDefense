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

        /*Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10f, Color.yellow, 5);
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity); 
        Vector2 projectileV = CalculateProjectile(SpawnPoint.position, hit.point, 1);

        Rigidbody2D rb = Instantiate(rb, SpawnPoint.position, Quaternion.identity);
        rb.velocity = projectileV;*/
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

    private Vector2 CalculateProjectile(Vector2 origin, Vector2 targetPoint, float time)
    {
        Vector2 dist = targetPoint - origin;

        float velocityX = dist.x / time;
        float velocityY = dist.y / time + 0.5f * Mathf.Abs(Physics2D.gravity.y);

        Vector2 ProjectileVelocity = new Vector2(velocityX, velocityY);

        return ProjectileVelocity;
    }


}
