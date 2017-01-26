using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject KeyPoofPrefab;
    public GameObject Door;
    public GameObject text;


    void Update()
	{
        //Bonus: Key Animation
        transform.Rotate(0, Time.deltaTime * 100f, 0);
    }

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        Object.Instantiate(KeyPoofPrefab, transform.position, Quaternion.identity);
        
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        Door.GetComponent<Door> ().hasKey = true;
        Debug.Log("Key: " + Door.GetComponent<Door>().hasKey);
        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
        showText();
    }
    void showText()
    {
        text.SetActive(true);
    }

}
