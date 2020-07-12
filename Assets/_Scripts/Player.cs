using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float forceScale;
    public bool isGround;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            this.GetComponent<Animator>().SetBool("IsRunning", true);
            this.transform.position += new Vector3(speed, 0, 0);
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.GetComponent<Animator>().SetBool("IsRunning", true);
            this.transform.position -= new Vector3(speed, 0, 0);
            this.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            this.GetComponent<Animator>().SetBool("IsRunning", false);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            this.GetComponent<Animator>().SetBool("IsRunning", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody2D>().AddForce(Vector2.up * forceScale, ForceMode2D.Impulse);
            this.GetComponent<Animator>().SetTrigger("IsJumping");
        }
        //this.GetComponent<Animator>().SetBool("IsJumping", false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = false;
        }
    }
}
