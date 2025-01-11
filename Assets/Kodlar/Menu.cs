using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //Bu Script ana menü scriptidir, kameranýn hareketinden sonra butonlarýn görünümünü ve butonlarýn çalýþmasýný kontrol eder
    public Button playButton; 
    public Button exitButton; 
    public Camera mainCamera; 
    public GameObject buttonsPanel; 
    public float cameraMoveSpeed = 2f; 
    public float targetCameraX = 12f;

    private bool cameraMoving = true; 

    void Start()
    {
        
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
        SceneManager.LoadScene(1); 
    }

    
    public void ExitGame()
    {
        Application.Quit(); 
        Debug.Log("Oyun kapatýldý."); 
    }
}
