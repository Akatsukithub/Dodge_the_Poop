using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject menuPlayerPrefab;
    public GameObject menuUnchiPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Player();
        InvokeRepeating("Unchi", 1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Game");
        }
    }

    private void Player()
    {
        Vector3 randomPlayer = new Vector3(Random.Range(-9f, 9f), Random.Range(-4f, 4f), transform.position.z);
        Vector3 playerRotation = new Vector3(0, 0, Random.Range(-360, 360));
        Instantiate(menuPlayerPrefab, randomPlayer, Quaternion.Euler(playerRotation));
    }

    private void Unchi()
    {
        Vector3 randomUnchi = new Vector3(Random.Range(-9f, 9f), Random.Range(-4f, 4f), transform.position.z);
        Vector3 unchiRotation = new Vector3(0, 0, Random.Range(-360, 360));
        Instantiate(menuUnchiPrefab, randomUnchi, Quaternion.Euler(unchiRotation));
    }
}
