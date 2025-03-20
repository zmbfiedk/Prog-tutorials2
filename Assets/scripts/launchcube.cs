using UnityEngine;

public class CubeLauncher : MonoBehaviour
{
    public float launchForce = 10f; // Adjustable launch force
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();

        if (rb == null)
        {
            Debug.LogError("Rigidbody not found! Make sure to add a Rigidbody component.");
        }
    }

    void OnMouseDown()
    {
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero; // Reset velocity before launching
            rb.angularVelocity = Vector3.zero; // Stop any rotation before launching
            rb.AddForce(Vector3.up * launchForce, ForceMode.Impulse);
        }
    }
}
