using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public float movespeed = 1f;
    private bool movedown = true;

    [SerializeField]
    private GameObject Platform_prefab;

    private GameObject Platform;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > -3)
            movedown = true;
        if (transform.position.y < -7)
            movedown = false;

        if (movedown == true)
            transform.position = new Vector2(transform.position.x, transform.position.y - movespeed * Time.deltaTime);
        if (movedown == false)
            transform.position = new Vector2(transform.position.x, transform.position.y + movespeed * Time.deltaTime);

    }

    public void SpawnPlatform()
    {
        Platform = Instantiate(Platform_prefab, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
        Platform.transform.SetParent(GameManager.instance.Platforms.transform);
    }
}
