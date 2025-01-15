//Men� ayarlar�n� butonlar�n� ve etkile�imleri ayarlar.
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Camera mainCamera;
    public GameObject buttonsPanel;
    public float cameraMoveSpeed = 2f;
    public float targetCameraX = 12f;

    private bool cameraMoving = true;

    void Start()
    {
        Time.timeScale = 1; // Sahne ba�lad���nda oyunun normal h�zda �al��mas�n� sa�lar

        if (buttonsPanel != null)
        {
            buttonsPanel.SetActive(false);
        }

        if (playButton != null)
        {
            playButton.onClick.AddListener(PlayGame);
        }

        if (exitButton != null)
        {
            exitButton.onClick.AddListener(ExitGame);
        }
    }

    void Update()
    {
        if (cameraMoving && mainCamera != null)
        {
            Vector3 targetPosition = new Vector3(targetCameraX, mainCamera.transform.position.y, mainCamera.transform.position.z);
            mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, targetPosition, cameraMoveSpeed * Time.deltaTime);

            if (mainCamera.transform.position.x >= targetCameraX)
            {
                cameraMoving = false;
                if (buttonsPanel != null)
                {
                    buttonsPanel.SetActive(true);
                }
            }
        }
    }

    public void PlayGame()
    {
        Time.timeScale = 1; // Oyun ba�lamadan �nce h�z�n s�f�rlanmad���n� ayarlar
        SceneManager.LoadScene(1); // �lk oyun sahnesini y�kler
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Oyun kapat�ld�.");
    }
}
