using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private BoxCollider2D bc;


    [SerializeField] private int damageDone;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
           other.gameObject.GetComponent<characterMovement>().Damage(damageDone);
           Debug.Log("Golpeo");
           bc.enabled = false;
        }
    }

}
