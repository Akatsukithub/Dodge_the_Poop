using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip poisonSE;
    public AudioClip diarrheaSE;

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
        if (collision.gameObject.name == "Player")
        {
            GameManager.instance.DiarrheaStart();
            audioSource.PlayOneShot(diarrheaSE);
            Destroy(this.gameObject, 0.5f);
        }

        if (collision.gameObject.name == "Ground")
        {
            audioSource.PlayOneShot(poisonSE);
            Destroy(this.gameObject, 0.5f);
        }
    }
}
