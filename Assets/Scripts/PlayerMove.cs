using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody2D rb;

    [SerializeField] float horizontalSpeed;
    [SerializeField] float verticalSpeed;

    //maximum and minimum y position of player 
    [SerializeField] float maxY;
    [SerializeField] float minY;

  


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        BoundriesCheck(); 
    }
    void BoundriesCheck()
    {
        float playerY = transform.position.y;
        float dir = Input.GetAxisRaw("Vertical");

        if (playerY <= maxY && dir > 0)
        {
            rb.velocity = (Vector2.up * dir * verticalSpeed) + (Vector2.right * horizontalSpeed);
        }
        else if (playerY >= minY && dir < 0)
        {
            rb.velocity = (Vector2.up * dir * verticalSpeed) + (Vector2.right * horizontalSpeed);

        }
        else
            rb.velocity = Vector2.right * horizontalSpeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Rock"))
        {
            Debug.Log("Rock", this);
        }
    }


}
