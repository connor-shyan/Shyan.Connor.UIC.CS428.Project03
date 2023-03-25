using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSodaCan : MonoBehaviour
{
    public GameObject sodaCan;
    public Transform parent;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    IEnumerator DelaySeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        GameObject newSodaCan = Instantiate(sodaCan, parent, false);
        newSodaCan.SetActive(true);
    }

    public void AddObject()
    {
        StartCoroutine(DelaySeconds(2.5f));
    }
}
