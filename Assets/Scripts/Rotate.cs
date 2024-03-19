using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Vector3 torque,angularV;

    private void RotateTorque()
    {
        rb.AddTorque(torque);
    }

    private void RotateAngularV()
    {
        rb.angularVelocity = angularV;
    }

    private void ShowInertia()
    {
        Debug.Log(this.name + "inertia: " + rb.inertiaTensor);

        rb.angularVelocity = rb.inertiaTensor;

        transform.localScale += new Vector3(Input.GetAxis("Horizontal"), 0, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RotateAngularV();
        }

        if (Input.GetMouseButtonDown(1))
        {
            RotateTorque();
        }

        ShowInertia();
    }
}
