using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = transform.right * moveHorizontal + transform.forward * moveVertical;

        Vector3 currentVelocity = rb.linearVelocity;
        rb.linearVelocity = new Vector3(moveDirection.x * moveSpeed, currentVelocity.y, moveDirection.z * moveSpeed);
    }
}
