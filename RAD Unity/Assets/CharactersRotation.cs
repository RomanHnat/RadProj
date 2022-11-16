using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersRotation : MonoBehaviour
{
    private float mouseX;
    private float mouseY;
    float xRotation = 0f;
    public float mouseSensitivity = 1000f;

    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;


    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 60f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        Player.Rotate(mouseX * new Vector3(0, 1, 0));
        
    }
}
