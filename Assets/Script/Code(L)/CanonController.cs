using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CanonController : MonoBehaviour
{

    [SerializeField] GameObject canon;
    [SerializeField] GameObject bullet;
    [SerializeField] Transform spawnPoint;

    private GameObject bulletinst;

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
        //transform.rotation = Quaternion.Euler(0, 0, rotationSpeed * Time.deltaTime);
    }

    private void CanonRotation()
    {
        worldPosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        direction = (worldPosition - (Vector2)canon.transform.position).normalized;
        canon.transform.right = direction;

        Vector3 localScale = Vector3.one;

        

        
    }

    private void CanonShooting()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            bulletinst = Instantiate(bullet, spawnPoint.position, canon.transform.rotation);
        }
    }

    
}
