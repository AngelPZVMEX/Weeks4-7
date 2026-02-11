using UnityEngine;

public class spinwheel : MonoBehaviour
{
    float speed = 389;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getspun()
    {
        for (int i = 0; i < 90; i++)
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z -= speed * Time.deltaTime;
            transform.eulerAngles = newRotation;
        }
    }
}
