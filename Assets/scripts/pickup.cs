using UnityEngine;

public class GetPickup : MonoBehaviour
{
    private AudioSource source;
    private ParticleSystem ps;
    private Renderer r;

    void Start()
    {
        r = GetComponent<Renderer>();
        source = GetComponent<AudioSource>();
        ps = GetComponent<ParticleSystem>();
        ps.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            r.enabled = false;
            source.Play();
            ps.Play();
            Destroy(gameObject, 0.5f);
        }
    }
}
