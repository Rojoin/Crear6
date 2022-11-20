using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class characterMovement : MonoBehaviour
{
    [SerializeField] float jumpForce;
    private bool jump = false;

    private Rigidbody2D rb;
    private Collider2D cl;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
     // cl = GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    void Jump()
    {

        if (Input.GetKeyDown(KeyCode.Space)&& !jump)
        {
            Debug.Log("Salto");
            rb.AddForce(new Vector2(0,jumpForce));
            jump = true;

        }
    }
   
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "ground")
        {
            Debug.Log("Entro"); 
            jump = false;
        }
    }
}
