using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool isGrounded;

    void OnTriggerEnter2D(collider2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            isGrounded = true;
        }
    }

    void OnTriggerStay2D(collider2D collision)
    {

    }

    void OnTriggerExit2D(collider2D collision)
}
