using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class spinwheel : MonoBehaviour
{
    // sets how much wheel spins
    float timer = 0;

    public GameObject gold;
    public GameObject ring;
    public GameObject bear;
    public GameObject ram;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer <= 6)
        {
            // makes the wheel do a cool spins, couldnt make the function work on button press but i left it in because it makes me happy
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z -= timer;
            transform.eulerAngles = newRotation;
        }
    }


    public void getspun()
    {

       //randomly picks a prefab

        
        
    }
}

