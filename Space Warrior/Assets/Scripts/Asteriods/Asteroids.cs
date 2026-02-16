using UnityEngine;

public class Asteroids : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject asteriods;
    [SerializeField] private float speed = 1f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            GameObject smallAsteriods = Instantiate(asteriods, transform.position, Quaternion.identity);
            Rigidbody2D rb = smallAsteriods.GetComponent<Rigidbody2D>();
            if(rb != null)
            {
                rb.AddForce(-transform.right * speed, ForceMode2D.Impulse);
            }
        }
    }
}