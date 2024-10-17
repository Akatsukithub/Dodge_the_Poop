using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashManager : MonoBehaviour
{
    public static bool isWashTime = false;
    public GameObject waterPrefab;

    private AudioSource audioSource;
    public AudioClip washSE;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isWashTime)
        {
            WashTime();
            Invoke("WashTime", 1.5f);
            Invoke("WashTime", 3f);
            Invoke("WashTime", 4.5f);
            isWashTime = false;
        }
    }

    private void WashTime()
    {
        AudioSource.PlayClipAtPoint(washSE, transform.position);

        Vector3 randomWater = new Vector3(18f, Random.Range(-1f, 0f), -1f);
        Instantiate(waterPrefab, randomWater, Quaternion.identity);
    }
}
