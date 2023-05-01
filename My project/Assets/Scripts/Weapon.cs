using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public abstract class Weapon : MonoBehaviour
{
    [field: SerializeField] public float AttackSpeed { get; protected set; }
    [field: SerializeField] public string SoundName { get; protected set; }
    private float lastAttack = Mathf.Infinity;
    protected bool canAttack = true;

    private void Update()
    {
        CheckRateOfFire();
    }

    private void CheckRateOfFire()
    {
        if (lastAttack >= 1 / AttackSpeed)
        {
            canAttack = true;
            lastAttack = 0;
        }
        lastAttack += Time.deltaTime;
    }

    public virtual void Attack(Animator animator)
    {
        if (!canAttack) return;
        //canAttack = false;
    }

}
