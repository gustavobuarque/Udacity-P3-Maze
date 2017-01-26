using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject CoinPoofPrefab;
    private float speed = 100f;

    void Start()
    {
        // rotaciona todas as moedas para ficarem na vertical
        transform.Rotate(90, 0, 90);
    }

    void Update()
    {
        //transform.position = new Vector3(147, 2.0f + Mathf.Sin(Time.time * 3.0f), 10);
        transform.Rotate(0, 0, Time.deltaTime * speed);
    }

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        Object.Instantiate(CoinPoofPrefab, transform.position, Quaternion.identity);
        CoinController.coinCount++;
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
    }

}
