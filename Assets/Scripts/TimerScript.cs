using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public static TimerScript instance;
    public float startTime;
    public float currentTime;
    public TMP_Text timerText;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
        timerText.text = currentTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (!AudioManagerScript.instance.playerDead)
        {
            currentTime += Time.deltaTime;
            //currentTime = Mathf.RoundToInt(currentTime);
            timerText.text = Mathf.RoundToInt(currentTime).ToString();
        }
        
        
    }
}
