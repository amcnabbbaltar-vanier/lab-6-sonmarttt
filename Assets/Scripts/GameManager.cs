using UnityEngine;
using UnityEngine.UI;
using TMPro;  
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int score = 0;
    public int targetScore = 4; // Score to reach before changing scenes
    public TextMeshProUGUI scoreText;
    void Awake()
    {
        // Singleton pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Optional
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void IncrementScore(int amount)
    {
        score += amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (scoreText != null)
        {
            scoreText.text = $"Score: {score}";
        }
    }


    public void LoadNextScene()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
    }

}


