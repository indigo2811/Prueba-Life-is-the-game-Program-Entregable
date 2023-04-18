using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //variables
    public Rigidbody rb;
    public GameObject  Camera1;
    public CharacterController controller;
    public float speed = 500f;

    
    

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        GameObject.DontDestroyOnLoad(this.gameObject);

    }

    // Update is called once per frame

    void Update()
    {


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
   
        Vector3 move = transform.right * x + transform.forward* z ;
        

        if (controller.enabled) {
            controller.SimpleMove(move * speed * Time.deltaTime);
        }
        
        

        ///SceneManager

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Game")) 
            {
            rb.isKinematic = false;
            Camera1.SetActive(true);
            controller.enabled = true;
        }

            else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Menu"))
            {
            rb.isKinematic = true;
            

            
        }

        



    }

}
