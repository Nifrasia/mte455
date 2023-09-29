using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string mapScene;
    [SerializeField] private string mainMenu;

    public GameObject settingPanel;
    public GameObject saveslotPanel;
    public GameObject manuPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToggleSettingPanel()
    {
        if (!settingPanel.activeInHierarchy)
            settingPanel.SetActive(true);
        else
            settingPanel.SetActive(false);
    }
    public void ToggleSaveSlotPanel()
    {
        if (!saveslotPanel.activeInHierarchy)
            saveslotPanel.SetActive(true);
        else
            saveslotPanel.SetActive(false);
    }
    public void ToggleManuPanel()
    {
        if (!manuPanel.activeInHierarchy)
            manuPanel.SetActive(true);
        else
            manuPanel.SetActive(false);
    }
    public void StartNewGame()
    {
        SceneManager.LoadScene(mapScene);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
