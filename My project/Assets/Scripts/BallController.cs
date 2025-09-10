using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public Vector2 direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        direction= Vector2.one.normalized; //(1,1)
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity= direction*speed;
    }

    void OnTriggerEnter2D(Collider2D collison){
        if (collison.gameObject.CompareTag("Paddle"))
            direction.y = -direction.y;
    }
}
