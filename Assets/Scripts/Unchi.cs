using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unchi : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip unchiSE;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Line"))
        {
            ScoreManager.instance.AddScore(1);
            Destroy(this.gameObject, 1f);
        }

        if (collision.gameObject.CompareTag("Paper"))
        {
            audioSource.PlayOneShot(unchiSE);
            Destroy(this.gameObject, 1f);
        }

        if (collision.gameObject.name == "Ground")
        {
            audioSource.PlayOneShot(unchiSE);
            Destroy(this.gameObject, 1f);
        }

        if (collision.gameObject.CompareTag("Unchi"))
        {
            audioSource.PlayOneShot(unchiSE);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Water"))
        {
            ScoreManager.instance.AddScore(100);
            Destroy(this.gameObject);
        }
    }
}
