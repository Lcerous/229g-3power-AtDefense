using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.GraphicsBuffer;

public class CanonController : MonoBehaviour
{

    [SerializeField] GameObject canon;
    [SerializeField] Transform spawnPoint;
    [SerializeField] Rigidbody2D bullet;
    [SerializeField] GameObject target;

    //private GameObject bulletinst;

    private Vector2 worldPosition;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CanonRotation();
        CanonShooting();
    }

    private void CanonRotation()
    {
        worldPosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        direction = (worldPosition - (Vector2)canon.transform.position).normalized;
        canon.transform.right = direction;
        target.transform.position = worldPosition;
        Vector3 localScale = Vector3.one;
    }

    private void CanonShooting()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 10f, Color.yellow, 5);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

            if (hit.collider != null)
            {
                Vector2 projectileV = CalculateProjectile(spawnPoint.position, worldPosition, 1);

                Rigidbody2D spawnBullet = Instantiate(bullet, spawnPoint.position, Quaternion.identity);

                spawnBullet.velocity = projectileV;
            }
            
        }
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
