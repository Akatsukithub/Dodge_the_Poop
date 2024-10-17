using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            WashManager.isWashTime = true;
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Unchi"))
        {
            Destroy(this.gameObject);
        }
    }
}
