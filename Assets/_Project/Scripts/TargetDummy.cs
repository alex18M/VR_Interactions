using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDummy : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private int _hits = 0;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet") )
        {
            animator.SetTrigger("Hit");
            Debug.Log("I've been hit");

            _hits++;

            if (_hits >= 3)
            {
                animator.SetBool("IsDead", true);
                _hits = 0; // Reiniciar el contador cuando el objeto muere.
            }
        }
    }
}