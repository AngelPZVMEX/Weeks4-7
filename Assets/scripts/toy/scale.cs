using UnityEngine;
using UnityEngine.UI;

public class scale : MonoBehaviour
{
   public Vector3 Scale;
    public Slider slider; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Scale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        //uses the sliders value to scale object
         Scale  =transform.localScale;
        Scale.x = slider.value;
        Scale.y = slider.value;
        transform.localScale = Scale;
    }
}
