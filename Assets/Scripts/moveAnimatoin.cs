using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAnimatoin : MonoBehaviour
{
    private Animator _animator;
    public bool IsMoving {private get; set;}
    private void Start() {
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate() {
        _animator.SetBool("IsMoving", IsMoving);
    }
}
