using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpForce = 5f;

    private Rigidbody2D myRB;
    private bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    //Jump Funktion
    public void Jump()
    {
        //Darf Spieler überhaupt springen?
        if (canJump)
        {
            canJump = false;
            myRB.velocity = new Vector2(0f, jumpForce);
        }
        
     }
     void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true;
    }
}
