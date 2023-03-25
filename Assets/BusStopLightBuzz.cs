using UnityEngine;
using System.Collections;

public class BusStopLightBuzz : MonoBehaviour
{
    
    public Light light;
    public AudioSource buzz;
    public ParticleSystem sparks;
    float minSpeed = 0.1f;
    float maxSpeed = 0.2f;

    void Start()
    {
        light = GetComponent<Light>();
        buzz = GetComponent<AudioSource>();
        StartCoroutine(lightBuzz());
    }

    IEnumerator lightBuzz()
    {
        while (true) {
            yield return new WaitForSeconds(Random.Range(5f, 10f));
            buzz.Play(0);
            light.enabled = false;
            sparks.Play();
            yield return new WaitForSeconds(Random.Range(minSpeed, maxSpeed));
            light.enabled = true;
            // sparks.Play();
            yield return new WaitForSeconds(Random.Range(minSpeed, maxSpeed));
            light.enabled = false;
            // sparks.Play();
            yield return new WaitForSeconds(Random.Range(minSpeed, maxSpeed));
            light.enabled = true;
            // sparks.Play();
            yield return new WaitForSeconds(Random.Range(minSpeed, maxSpeed));
            light.enabled = false;
            // sparks.Play();
            yield return new WaitForSeconds(Random.Range(minSpeed, maxSpeed));
            light.enabled = true;
            sparks.Stop();
        }
    }
}