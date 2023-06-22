using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverText;
    public Image gameOverImage;
    private static GameOver instance;

    private void Start()
    {
        gameOverText.SetActive(false);
        gameOverImage.enabled = false;
    }

    public static void Show()
    {
        if (instance == null)
        {
            instance = FindObjectOfType<GameOver>();
        }
        
        instance.gameOverText.SetActive(true);
        instance.gameOverImage.enabled = true;
    }
}
