using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Platform"))
        {
            Debug.Log("Platform destroy");
            Destroy(other.gameObject);
            FindObjectOfType<PlatformSpawner>().SpawnPlatform();

        }
    }

}
