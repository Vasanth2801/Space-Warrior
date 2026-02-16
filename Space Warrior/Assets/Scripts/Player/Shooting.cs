using UnityEngine;

public class Shooting : MonoBehaviour
{
    [Header("Shoot Settings")]
    [SerializeField] private float bulletForce = 15f;

    [Header("References")]
    [SerializeField] private Transform firePoint;
    ObjectPooler pooler;

    void Start()
    {
        pooler = FindObjectOfType<ObjectPooler>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
            Debug.Log("Button Pressed");
        }
    }

    void Shoot()
    {
        GameObject bullet = pooler.SpawnFromPools("Bullet", firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.AddForce(firePoint.right * bulletForce,ForceMode2D.Impulse);
        }
    }
}