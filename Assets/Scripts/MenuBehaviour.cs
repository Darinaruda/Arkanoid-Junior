using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
public class MenuBehaviour : MonoBehaviour
    
{   
    public AudioMixer audioMixer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
    public void Play()
    {
        SceneManager.LoadScene("Level");
    }

    public void Settings()
    { 
    
    }

    public void Quit()
    { 
        Application.Quit();
    }

    public void Pause()
    { 
        Time.timeScale = 1.0f;

    }



}
