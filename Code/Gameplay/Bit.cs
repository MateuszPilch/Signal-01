using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bit : MonoBehaviour
{
    Rigidbody2D rb;

    [HideInInspector]
    public int bitStatus;
    public float timeToDestroy;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, timeToDestroy);
    }

    private void FixedUpdate()
    {
        rb.velocity = -transform.up * 300 * Time.fixedDeltaTime ;
    }

}
