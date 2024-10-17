using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    private Rigidbody2D waterRigid;

    // Start is called before the first frame update
    void Start()
    {
        waterRigid = this.GetComponent<Rigidbody2D>();

        Vector3 waterForce = new Vector3(-200, 0, 0);
        waterRigid.AddForce(waterForce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
