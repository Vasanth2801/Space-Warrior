using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Settings")]
    [SerializeField] public AudioClip bgmusic;
    [SerializeField] public AudioSource audioSource;


    public static AudioManager instance;

    void Awake()
    {
        if (instance == null)
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
        if(audioSource != null && bgmusic != null)
        {
            audioSource.clip = bgmusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }
}