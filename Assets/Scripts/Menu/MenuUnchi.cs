using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUnchi : MonoBehaviour
{
    private Rigidbody2D unchiRigid;

    private AudioSource audioSource;
    public AudioClip unchiSE;

    // Start is called before the first frame update
    void Start()
    {
        unchiRigid = this.gameObject.GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();

        Vector2 randomForce = new Vector3(Random.Range(-2, 2) * 100, Random.Range(-2, 2) * 100, transform.position.z);
        unchiRigid.AddForce(randomForce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.PlayOneShot(unchiSE);
    }
}
