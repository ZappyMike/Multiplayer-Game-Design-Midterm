using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class CoinCounter : MonoBehaviour
{

    public int coinCount;

    void Start()
    {
        coinCount = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            Destroy(collision.collider.gameObject);
            coinCount += 1;
        }
    }

    void Update()
    {
        if(coinCount >= 10)
        {
            SceneManager.LoadScene("End");
        }
    }
}
