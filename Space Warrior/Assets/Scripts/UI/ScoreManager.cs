using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [Header("Score")]
    [SerializeField] int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;
 
    public static ScoreManager instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    void Update()
    {
        scoreText.text = "Score : " + score.ToString();
    }

    public void AddScore(int amount)
    {
        score += amount;
    }
}
