using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour
{
    [SerializeField] float Speed;
    private Vector3 direction;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        direction = transform.forward;
        direction.Normalize();
        rb.velocity = direction * Speed;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.GetComponent<RangeWeapon>() == null)
        Destroy(gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
