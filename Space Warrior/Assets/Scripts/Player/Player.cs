using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 verticalMovement;
    Rigidbody2D rb;
    private PlayerController controls;

    public PlayerHealth health;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        controls = new PlayerController();

        Movement();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            health.TakeDamage(10);
        }
    }

    void Movement()
    {
        controls.Player.Move.performed += ctx => verticalMovement = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => verticalMovement = Vector2.zero;
    }

    void OnEnable()
    {
        controls.Player.Enable();
    }

    void OnDisable()
    {
        controls.Player.Disable();
    }

    void FixedUpdate()
    {
        Vector2 move = rb.position + verticalMovement * speed * Time.fixedDeltaTime;
        rb.MovePosition(move);
    }
}