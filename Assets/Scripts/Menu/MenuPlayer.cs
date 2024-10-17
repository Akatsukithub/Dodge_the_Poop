using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPlayer : MonoBehaviour
{
    private Rigidbody2D playerRigid;

    // Start is called before the first frame update
    void Start()
    {
        playerRigid = this.gameObject.GetComponent<Rigidbody2D>();

        Vector2 randomForce = new Vector3(Random.Range(-2, 2) * 100, Random.Range(-2, 2) * 100, transform.position.z);
        playerRigid.AddForce(randomForce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
