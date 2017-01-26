using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 
    bool locked = false;
    public bool hasKey = false;
    public AudioClip[] soundFiles;
    public AudioSource soundSource;
    public GameObject text;

    void Update() {
        // If the door is unlocked and it is not fully raised
        //Debug.Log(locked);
        //Debug.Log(transform.position.y);

        if (locked || transform.position.y == 12)
            {
            // Animate the door raising up
            if (transform.position.y < 24)
            {
                transform.Translate(0, 2.0f * Time.deltaTime, 0, Space.World);
            }
        }
    }

    public void DoorClicked()
    {
        if (!hasKey)
        {
            //locked
            showText();
            Debug.Log("Locked");
            soundSource.clip = soundFiles[0];
            soundSource.Play();

        } else
        {
            Debug.Log("Unlocked");
            Unlock();
            soundSource.clip = soundFiles[1];
            soundSource.Play();
            text.SetActive(false);
        }

    }

    public void Unlock()
    {
        // You'll need to set "locked" to true here
        locked = true;
    }

    void showText()
    {
        text.SetActive(true);
    }
}
