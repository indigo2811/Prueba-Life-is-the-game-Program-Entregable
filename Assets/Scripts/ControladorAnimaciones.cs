using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAnimaciones : MonoBehaviour
{

    public GameObject personaje;
    public Animation baile1;
    public Animation baile2;
    public Animation baile3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void ButtonClicked(int buttonNo)
    {
        //Output this to console when the Button3 is clicked
        Debug.Log("Button clicked = " + buttonNo);
    }
}
