using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPlayer : MonoBehaviour
{

    public GameObject character;
    
    public void Restart()
    {
        gameObject.transform.position = new Vector3(-5.22f, 1.53f, 0);
    }
}
