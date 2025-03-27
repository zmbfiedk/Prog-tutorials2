using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;
    public float force = 20f;
    private bool onFloor = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onFloor)
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            onFloor = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("floor"))
        {
            onFloor = true;
        }
    }
}
