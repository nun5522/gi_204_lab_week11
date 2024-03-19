using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeKick : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Vector3 velocity,angularV;

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = velocity;
            rb.angularVelocity = angularV;
        }

        rb.AddForce(Vector3.Cross(rb.velocity, rb.angularVelocity));
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Shoot();
    }
}
