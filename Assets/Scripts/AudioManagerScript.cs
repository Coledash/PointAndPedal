using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManagerScript : MonoBehaviour
{
    public static AudioManagerScript instance;
    public AudioSource soundFXObject;
    public AudioClip music;
    public bool playerDead = false;
    AudioSource myMusic;
    public GameObject restartScreen;
    public float timeSinceStart;
    public float highScore;
    public TMP_Text highScoreText;
    public float startTime;
    public float currentTime;
    public TMP_Text timerText;

    private void Start()
    {
        
        currentTime = 0;
        timerText.text = "Your score: " + currentTime.ToString();
    }
    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
        AudioSource audioSource = Instantiate(soundFXObject, transform.position, Quaternion.identity);
        audioSource.clip = music;
        audioSource.volume = 0.4f;
        audioSource.loop = true;
        audioSource.Play();
        myMusic = audioSource;
        //float clipLength = audioSource.clip.length;
        //Destroy(audioSource.gameObject, clipLength);
    }

    private void Update()
    {
        
        if (playerDead)
        {
            myMusic.Stop();
            restartScreen.SetActive(true);
            
            if(GameManagerScript.instance.highScore < currentTime)
            {
                GameManagerScript.instance.highScore = currentTime;
            }
            //Debug.Log("Current time: " + currentTime);
            //Debug.Log("GameManager high score: " + GameManagerScript.instance.highScore);
        }

        timeSinceStart += Time.deltaTime;

        if (!playerDead)
        {
            currentTime += Time.deltaTime;
            //currentTime = Mathf.RoundToInt(currentTime);
            timerText.text = "Your score: " + Mathf.RoundToInt(currentTime).ToString();
        }

        highScoreText.text = "High score: " + Mathf.RoundToInt(GameManagerScript.instance.highScore).ToString();

        //Debug.Log(timeSinceStart);
    }

    public void PlaySoundClip(AudioClip audioClip, Transform spawnTransform, float volume)
    {
        AudioSource audioSource = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);
        audioSource.clip = audioClip;
        audioSource.volume = volume;
        audioSource.Play();
        float clipLength = audioSource.clip.length;
        Destroy(audioSource.gameObject, clipLength);

    }

    public void PlayRandomSoundClip(AudioClip[] audioClip, Transform spawnTransform, float volume)
    {
        int rand = UnityEngine.Random.Range(0, audioClip.Length);
        AudioSource audioSource = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);
        audioSource.clip = audioClip[rand];
        audioSource.volume = volume;
        audioSource.Play();
        float clipLength = audioSource.clip.length;
        Destroy(audioSource.gameObject, clipLength);

    }
}
