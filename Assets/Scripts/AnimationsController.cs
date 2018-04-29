using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsController : MonoBehaviour
{
    public string triggerToSet;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void SetAnimatorTrigger()
    {
        animator.SetTrigger(triggerToSet);
    }
}
