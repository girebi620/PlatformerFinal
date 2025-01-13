using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowTime : MonoBehaviour
{
    public GameManager gameManager;
    public Slider slider;
    public Text text;
    public GameObject panel;
    public Button playAgainButton;
    public Button mainMenuButton;
    public AudioSource audioSource; 

    private bool isSoundPlayed = false; // Sesin yalnýzca bir kez çalýndýðýný kontrol eder

    void Start()
    {
        slider.maxValue = gameManager.time;
        panel.SetActive(false);
        playAgainButton.onClick.AddListener(RestartScene);
        mainMenuButton.onClick.AddListener(GoToMainMenu);
        Time.timeScale = 1;
    }

    void Update()
    {
        slider.value = gameManager.time;
        text.text = slider.value.ToString("0.00");

        if (slider.value <= 0 && !panel.activeSelf)
        {
            OpenPanel();
        }
    }

    IEnumerator DecreaseTime()
    {
        while (gameManager.time > 0)
        {
            gameManager.time--;
            yield return new WaitForSeconds(1);
        }
    }

    void OpenPanel()
    {
        panel.SetActive(true);
        Time.timeScale = 0;

        if (!isSoundPlayed && audioSource != null) // Ses yalnýzca bir kez çalýnýr
        {
            audioSource.Play();
            isSoundPlayed = true;
        }
    }

    void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void GoToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
