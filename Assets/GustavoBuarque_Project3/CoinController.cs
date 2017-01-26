using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    public static int coinCount = 0;
    private Text textField;
    public Camera cam;
    public GameObject Door;
    int _key;

    void Awake()
    {
        textField = GetComponent<Text>();
    }

    void Start()
    {
        if (cam == null)
        {
            cam = Camera.main;
        }

        if (cam != null)
        {
            // Tie this to the camera, and do not keep the local orientation.
            transform.SetParent(cam.GetComponent<Transform>(), true);
        }
    }

    void LateUpdate()
    {
        if (Door.GetComponent<Door>().hasKey)
        {
            _key = 1;
        }
        else
        {
            _key = 0;
        }
        textField.text = "$" + coinCount.ToString() + " Key: " + _key;
    }
}