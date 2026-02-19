using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class spinwheel : MonoBehaviour
{
    // setsvariables
    float timer = 0;
  
    public GameObject gold;
    public GameObject ring;
    public GameObject bear;
    public GameObject ram;
    public TextMeshProUGUI guess; 

    float choice;
    bool weguessed = false;
    float price;
    float guesss;

    public Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //randomly generates prefab and price
        price = Random.Range(1, 360);
    choice = Random.Range(0, 3);
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
        //displays your guess
       guesss = slider.value;
        guess.text = guesss.ToString();
    }


    public void getspun()
    {

        //randomly picks a prefab and instantiates it


        if (weguessed == false)
        {
            

            if (choice == 0)
            {
                Instantiate(gold);
            }
            if (choice == 1)
            {
                Instantiate(ring);
            }
            if (choice == 2)
            {
                Instantiate(bear);
            }
            if (choice == 3)
            {
                Instantiate(ram);

            }

            weguessed = true;
        }
    }

    public void finalGUess()
    {
        //destroys prefab and gives win loss
        if (-50 <= (guesss - price) && (guesss - price) >= 50)
        {
            guess.text = "you win!";
        }
        else
        {
            guess.text = "you lose :(";
        }
        
            Destroy(gold);
        
       
            Destroy(ring);
       
            Destroy(bear);
        
      
            Destroy(ram);

        
    }
}

