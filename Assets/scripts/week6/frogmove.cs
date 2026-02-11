using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem;

public class frogmove : MonoBehaviour
{
    public float speed = 3f;
    Vector2 newposition;
    Vector2 startpos;
    bool won = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startpos = transform.position;
        newposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current.spaceKey.wasPressedThisFrame == true)
        {
            newposition.y += speed;
            transform.position = newposition;
        }

        while (won == true)
        {
            




        }

    }

    void death()
    {
        transform.position = startpos;
    }

    void win()
    {
        newposition.x = 0;
        newposition.y = 0;
        transform.position = newposition;
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z -= speed * Time.deltaTime;
        transform.eulerAngles = newRotation;
    }

}
