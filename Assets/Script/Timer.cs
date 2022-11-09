using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float StartingTime = 60f;

    [SerializeField] TextMeshProUGUI countdown;


    void Start()
    {
        currentTime = StartingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        countdown.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
        }

        if (currentTime == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); ;
        }
    }
}
