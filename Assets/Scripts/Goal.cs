using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{

    public int currentLevelIndex = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            LoadNextLevel();
            
        }
    }

    public void LoadNextLevel()
    {
        currentLevelIndex++;
        LoadLevelByIndex(currentLevelIndex);
    }
    private void LoadLevelByIndex(int index)
    {
        SceneManager.LoadScene(currentLevelIndex);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
