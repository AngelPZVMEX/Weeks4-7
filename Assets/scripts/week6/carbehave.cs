using UnityEngine;

public class carbehave : MonoBehaviour
{
    public float speed = 0.01f;
    Vector2 carstart;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        carstart.y = Random.Range(-3, 3);
        transform.position = carstart;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x += speed;
        transform.position = newPos;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        //if (screenPos.x > Screen.width)
        //{
          
        //    newPos.x = ;
        //    transform.position = newPos;

        //}
    }
}
