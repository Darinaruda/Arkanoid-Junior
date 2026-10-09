using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseBehaviour : MonoBehaviour
{
    private float vol;
    public bool IsPaused, isSettings;
    public GameObject pauseMenu,settingsMenu;
    public AudioMixer audioMixer;
    public Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;
        Time.timeScale = 1.0f;
        audioMixer.GetFloat("volume", out vol);
        slider.value = vol;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                if (isSettings)
                {
                    settingsMenu.SetActive(false);
                    pauseMenu.SetActive(true);
                    isSettings = false;
                }
                else
                {
                    Resume();
                }

            }
            else
            {
                Pause();
            }
        }
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
    public void Play()
    {
        SceneManager.LoadScene("Level");
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
        Cursor.visible = false;
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
        Cursor.visible = true;

    }
    public void Settings()
    { 
        isSettings = true;
        
    }
    public void Quit()
    {
        Application.Quit();
    }
}
