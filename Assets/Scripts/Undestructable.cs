using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Undestructable : MonoBehaviour
{

    public Rigidbody rb;
    public GameObject Camera1;
    public playerMovement movementPlayer;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Game"))
        {
            rb.isKinematic = false;
            Camera1.SetActive(true);
            movementPlayer.enabled = true;

        }

        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Menu"))
        {
            rb.isKinematic = true;



        }
    }
}
