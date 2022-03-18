
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWin : MonoBehaviour
{

    public GameObject WinningScreen;
    public void WinGame()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player Win");
            WinningScreen.SetActive(true);
            Timer.instanciar.FinTiempo();
        }
    }
}
