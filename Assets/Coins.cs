using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] private int value;

    private BoxCollider2D bc;

    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
          //  other.GetComponent<characterMovement>().addPoints(value);
        }
    }


}
