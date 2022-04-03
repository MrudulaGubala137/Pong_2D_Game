using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed;
    float movementY;
    public bool isPlayer1;
    Rigidbody2D rb;
    public Vector3 startPosition;
    GameObject player1;
    void Start()
    {
       rb= GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            movementY = Input.GetAxis("Vertical");
        }
        else
        {
            movementY = Input.GetAxis("Vertical2");
        }
        rb.velocity =new Vector2(rb.velocity.x ,movementY* playerSpeed);
        
    }
   
}
