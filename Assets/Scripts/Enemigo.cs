using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float movementSpeed = 4;
    public int direction = 1;
    public Rigidbody2D rBody2D;
    private Animator animator;

    private SpriteRenderer renderer;



    void Awake()
    {
        animator = GetComponent<Animator>();
        rBody2D = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
        
    }
    void Start()
    {
    

    }

    void Update()
    {
     
         
    }
     void FixedUpdate()
    {
      rBody2D.linearVelocity = new Vector2(direction * movementSpeed, rBody2D.linearVelocity.y);  
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       if (!collision.gameObject.CompareTag("Suelo Para Enemigos"))
        {
          direction *= -1;
        }
    }

}
