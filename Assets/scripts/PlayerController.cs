using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{

    public Vector3 startPosition;

    public float movementSpeed = 5f;
    public float jumpForce = 10;


    private InputAction moveAction;
    public Vector2 moveDirection;
    private InputAction jumpAction;

    public Rigidbody2D rBody2D;
    private SpriteRenderer SpriteRenderer;

    void Awake()
    {
        rBody2D = GetComponent<Rigidbody2D>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        moveAction = InputSystem.actions["Move"];
        jumpAction = InputSystem.actions["Jump"];
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = startPosition;

        

    
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = moveAction.ReadValue<Vector2>();
        //transform.position = new Vector3(transform.position.x + direction * movementSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        

        //transform.position = new Vector3(transform.position.x + moveDirection.x * movementSpeed * Time.deltaTime, transform.position.y, transform.position.z);

        if(moveDirection.x == 1)

        if(jumpAction.WasPressedThisFrame())
        {
             rBody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

void FixedUpdate()
{
    rBody2D.linearVelocity = new Vector2(moveDirection.x * movementSpeed, rBody2D.linearVelocity.y);

}
    
}
