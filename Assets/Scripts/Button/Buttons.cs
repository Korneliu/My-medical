using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    [SerializeField] private GameObject panelExit;
    [SerializeField] private GameObject panelSettings;
    [SerializeField] private GameObject panelLanguage;
    [SerializeField] private GameObject playerButtonSelect;
    [SerializeField] private GameObject playerButtonPlay;
    [SerializeField] private GameObject animalButtonSelect;
    [SerializeField] private GameObject animalButtonPlay;
    [SerializeField] private GameObject buyAnimal;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        FindObjectOfType<AudioManager>().PlaySound("Button");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ClosePanelExitGame()
    {
        panelExit.SetActive(false);
        panelSettings.SetActive(true);
        FindObjectOfType<AudioManager>().PlaySound("Button");
    }

    public void OpenExitPanelGame()
    {
        panelExit.SetActive(true);
        panelSettings.SetActive(false);
        FindObjectOfType<AudioManager>().PlaySound("Button");
    }

    public void OpenSettingsPanel()
    {
        panelSettings.SetActive(true);
        FindObjectOfType<AudioManager>().PlaySound("Button");
    }

    public void CloseSettingsPanel()
    {
        panelSettings.SetActive(false);
        FindObjectOfType<AudioManager>().PlaySound("Button");
    }

    public void OpenLanguegePanel()
    {
        panelLanguage.SetActive(true);
        panelSettings.SetActive(false);
        FindObjectOfType<AudioManager>().PlaySound("Button");
    }

    public void CloseLanguegePanel()
    {
        panelLanguage.SetActive(false);
        panelSettings.SetActive(true);
        FindObjectOfType<AudioManager>().PlaySound("Button");
    }

    public void SelectPlayer()
    {
        playerButtonSelect.SetActive(true);
        animalButtonSelect.SetActive(false);
        playerButtonPlay.SetActive(true);
        animalButtonPlay.SetActive(false);
        FindObjectOfType<AudioManager>().PlaySound("Button");
    }

    public void SelectAnimal()
    {
        animalButtonSelect.SetActive(true);
        playerButtonSelect.SetActive(false);
        animalButtonPlay.SetActive(true);
        playerButtonPlay.SetActive(false);
        FindObjectOfType<AudioManager>().PlaySound("Button");
    }

    public void MeniuGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        FindObjectOfType<AudioManager>().PlaySound("Button");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        FindObjectOfType<AudioManager>().PlaySound("Button");
    }

    public void BuyAnimal()
    {
        if(Coins.coinsCount >= 100)
        {
            Coins.coinsCount -= 100;
            buyAnimal.SetActive(false);
            PlayerPrefs.SetInt("Medi", PlayerPrefs.GetInt("Medi") - 100);
        }
    }
}
