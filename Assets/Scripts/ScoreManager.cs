using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public GameObject player;
    public GameObject scoreTextPrefab;
    public GameObject highScoreTextPrefab;

    private int score = 0;
    private int highScore = 0;
    public Text scoreText;
    public Text highScoreText;

    private AudioSource audioSource;
    public AudioClip scoreSE;
    public AudioClip highScoreSE;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score : " + score.ToString();

        highScore = PlayerPrefs.GetInt("highscore", 0);
        highScoreText.text = "High Score : " + highScore.ToString();

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int point)
    {
        if (GameManager.isOver != true)
        {
            score += point;
            scoreText.text = "Score : " + score.ToString();
            highScoreText.text = "High Score : " + highScore.ToString();

            if (point == 1)
            {
                Instantiate(scoreTextPrefab, player.transform.position, Quaternion.identity);
                AudioSource.PlayClipAtPoint(scoreSE, transform.position);
            }

            if (point == 100)
            {
                Instantiate(highScoreTextPrefab, player.transform.position, Quaternion.identity);
                AudioSource.PlayClipAtPoint(highScoreSE, transform.position);
            }
        }

        if (score > highScore)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }
}
