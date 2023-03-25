using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Payphone : MonoBehaviour
{
    public GameObject coin;
    public Transform parent;
    public AudioSource dial;
    public AudioSource ring;
    public AudioSource coindrop;
    public AudioSource busy;

    // Start is called before the first frame update
    void Start()
    {
        // dial = GetComponent<AudioSource>();
        // ring = GetComponent<AudioSource>();
        // busy = GetComponent<AudioSource>();
    }

    IEnumerator PayphoneAudioCoin()
    {
        dial.Play(0);
        yield return new WaitForSeconds(7.5f);
        ring.Play(0);
        yield return new WaitForSeconds(17.5f);
        coindrop.Play(0);
        GameObject newCoin = Instantiate(coin, parent, false);
        newCoin.SetActive(true);
        yield return new WaitForSeconds(1f);
        busy.Play(0);
        yield return new WaitForSeconds(9.5f);
    }

    public void StartPayphone()
    {
        StartCoroutine(PayphoneAudioCoin());
    }
}
