using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject player;

    public GameObject unchiPrefab;
    public GameObject paperPrefab;
    public GameObject poisonPrefab;

    public static bool isOver = false;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Unchi", 1, 1);
        InvokeRepeating("Paper", 10, 40);
        InvokeRepeating("Poison", 5, 20);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Unchi()
    {
        Vector3 randomUnchi = new Vector3(Random.Range(-10f, 10f), 5f, transform.position.z);
        Vector3 unchiRotation = new Vector3(0, 0, Random.Range(-360, 360));
        Instantiate(unchiPrefab, randomUnchi, Quaternion.Euler(unchiRotation));
    }


    private void Paper()
    {
        Vector3 randomPaper = new Vector3(Random.Range(-10f, 10f), 5f, transform.position.z);
        Vector3 paperRotation = new Vector3(0, 0, Random.Range(-360, 360));
        Instantiate(paperPrefab, randomPaper, Quaternion.Euler(paperRotation));
    }

    private void Poison()
    {
        Vector3 randomPoison = new Vector3(Random.Range(-10f, 10f), 5f, transform.position.z);
        Vector3 PoisonRotation = new Vector3(0, 0, Random.Range(-360, 360));
        Instantiate(poisonPrefab, randomPoison, Quaternion.Euler(PoisonRotation));
    }

    private void Diarrhea()
    {
        Vector3 randomUnchi = new Vector3(Random.Range(-10f, 10f), 5f, transform.position.z);
        Vector3 unchiRotation = new Vector3(0, 0, Random.Range(-360, 360));
        Instantiate(unchiPrefab, randomUnchi, Quaternion.Euler(unchiRotation));
    }

    public void DiarrheaStart()
    {
        InvokeRepeating("Diarrhea", 0.5f, 0.1f);
        Invoke("DiarrheaEnd", 7);
    }

    private void DiarrheaEnd()
    {
        CancelInvoke("Diarrhea");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Game");
        isOver = false;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        isOver = false;
    }
}
