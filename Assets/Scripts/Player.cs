using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public GameObject gameOverUI;

    private AudioSource audioSource;
    public AudioClip playerSE;

    Vector3 movePosition;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        movePosition = randomPosition();
    }

    // Update is called once per frame
    void Update()
    {
        if (movePosition == player.transform.position)
        {
            movePosition = randomPosition();
        }

        player.transform.position = Vector3.MoveTowards(player.transform.position, movePosition, 2f * Time.deltaTime);
    }

    private Vector3 randomPosition()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-9, 9), transform.position.y, transform.position.z);
        return randomPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Unchi"))
        {
            AudioSource.PlayClipAtPoint(playerSE, new Vector3(0, 0, 0));
            Destroy(this.gameObject, 1f);
            GameManager.isOver = true;
            gameOverUI.SetActive(true);
        }
    }
}
