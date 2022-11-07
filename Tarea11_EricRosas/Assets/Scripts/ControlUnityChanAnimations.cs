using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlUnityChanAnimations : MonoBehaviour
{
    private Animator _animator;

    private int _ahJumpTrigger;
    private int _ahRunTrigger;
    private int _ahDamageTrigger;

    private void Awake()
    {
        SetComponentes();
        SetAnimatorHashes();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetTrigger(_ahJumpTrigger);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _animator.SetTrigger(_ahRunTrigger);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _animator.SetTrigger (_ahDamageTrigger);
        }
    }

    private void SetComponentes()
    {
        _animator = GetComponent<Animator>();
    }
    private void SetAnimatorHashes()
    {
        _ahJumpTrigger = Animator.StringToHash("Jump");
        _ahRunTrigger = Animator.StringToHash("Run");
        _ahDamageTrigger = Animator.StringToHash("Damage");
    }
}
