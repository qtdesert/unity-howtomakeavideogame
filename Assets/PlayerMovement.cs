using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    // Update is called once per frame (FixedUpdate because we are using it to mess with physics)
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime); // Add a force of 2000 on the z-axis
    }
}
