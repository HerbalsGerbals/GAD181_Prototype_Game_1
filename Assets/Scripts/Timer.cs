using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float targetTime = 10.0f;
    [SerializeField] private Slider timerUI;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Timer Script Working");
    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;
        timerUI.value = targetTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
            
        }

    }
    private void timerEnded()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Time ran out");
    }
}

