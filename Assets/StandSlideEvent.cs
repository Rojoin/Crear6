using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandSlideEvent : MonoBehaviour
{
    [SerializeField] characterMovement movement;
    [SerializeField] private Animator anim;
    public void DoEvent()
    {
        anim.SetTrigger("Run");
        movement.StandSlide();
    }
}
