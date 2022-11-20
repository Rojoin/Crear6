using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class characterMovement : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private float rightSpeed;
    [SerializeField] private float jumpForce;
    private bool jump = false;

    private Rigidbody2D rb;
    private Collider2D cl;


    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // cl = GetComponent<Collider2D>();

    }

    // Update is called once per frame
    private void Update()
    {

        Slide();
        Jump();
        MoveToRight();
    }

    private void Slide()
    {

    }

    private void MoveToRight()
    {
        transform.Translate(Vector2.right * rightSpeed * Time.deltaTime);
    }

    private void Jump()
    {

        if (Input.GetKeyDown(KeyCode.Space) && !jump)
        {
            if (Random.Range(0, 2) == 1)
                anim.SetTrigger("Jump");
            else
                anim.SetTrigger("Mortal");

            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            jump = true;
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "ground")
        {
            anim.SetTrigger("Run");
            Debug.Log("Entro");
            jump = false;
        }
    }
}
