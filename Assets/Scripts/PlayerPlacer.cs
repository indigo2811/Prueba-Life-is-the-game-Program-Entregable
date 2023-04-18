using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlacer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Vector3 startPos;

    void  Start ()
    {
        GameObject player = GameObject.FindWithTag("Player");
        player.transform.position = startPos;
    }
}
