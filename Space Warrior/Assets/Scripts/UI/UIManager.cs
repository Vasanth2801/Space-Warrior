using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [Header("Instructions Panel")]
    [SerializeField] private GameObject instructionsPanel;
    public static UIManager instance;

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
        Time.timeScale = 0f;
        instructionsPanel.SetActive(true);
    }

    public void Ok()
    {
        Time.timeScale = 1f;
        instructionsPanel.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}