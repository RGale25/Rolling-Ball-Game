using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public LevelManager level;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Occured");

        if (collision.collider.tag == "collectable")
        {
            Debug.Log("Collectable hit");
            Destroy(collision.gameObject);
            level.incCollected();
        }

        if (collision.collider.tag == "finish")
        {
            Debug.Log("Finish entered");
            level.levelComplete();
        }
    }

    void Update()
    {
        if (transform.position.y < - 5)
        {
            transform.position = level.spawnPoint;
        }
    }
}
