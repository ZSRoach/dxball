using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public scoreScript score;
    public Vector2 direction;
    public int brickCount = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        direction = Vector2.one.normalized; //(1,1)
        score = GameObject.FindGameObjectWithTag("Logic").GetComponent<scoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity= direction*speed;
    }

    void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Paddle"))
            direction.y = -direction.y;
        if (collision.gameObject.CompareTag("Brick")){
            direction.y = -direction.y;
            Destroy(collision.gameObject);
            brickCount += 1;
            score.addScore(1);  
            Debug.Log("Bricks destroyed: "+brickCount);
        }
        if (collision.gameObject.CompareTag("Wall")){
            direction.x = -direction.x;
        }
        if (collision.gameObject.CompareTag("Ceiling")){
            direction.y = -direction.y;
        }
        if (collision.gameObject.CompareTag("Void")){
            gameObject.SetActive(false);
            score.addScore(0);
        }
    }
}
