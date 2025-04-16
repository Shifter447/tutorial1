using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPickUp : MonoBehaviour
{
    private AudioSource source;
    private Renderer r;
    private ParticleSystem ps;
    private KeepScore scoreScript;


    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
        source = GetComponent<AudioSource>();
        ps = GetComponent<ParticleSystem>();
        ps.Stop();
        scoreScript = FindObjectOfType<KeepScore>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ps.Play();
            r.enabled = false;
            GameObject.Destroy(gameObject, 0.5f);
            source.Play();
            scoreScript.AddScore(5);
        }
    }
}
