using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered");
            GameManager.instance.PauseDisplay.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}
