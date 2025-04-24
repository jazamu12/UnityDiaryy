using UnityEngine;

public class Movimientojugador : MonoBehaviour
{
    float velocidad = 20f;
    private Rigidbody2D rb;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(velocidad, rb.linearVelocity.y);
    }
    void Update()
    {

        rb.linearVelocity = new Vector2(velocidad, rb.linearVelocity.y);
        
    }
}
