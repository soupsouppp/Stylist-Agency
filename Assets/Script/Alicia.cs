using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alicia : MonoBehaviour
{
    public bool wearingRed;
    public bool wearingBlack;
    public bool wearingHeels;

    public bool wearingFormalTop;
    public bool wearingFormalBot;
    public bool wearingFormalHair;

    public GameObject ReactionHappy;
    public GameObject ReactionUnhappy;
    public GameObject ReactionShy;
    public GameObject ReactionQuestion;

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("BlackDress") || other.CompareTag("BlackSkirt") || other.CompareTag("BlackPants")
            || other.CompareTag("BlackShirt"))
        {
            wearingBlack = true;

        }

        if (other.CompareTag("RedDress") || other.CompareTag("RedSkirt") || other.CompareTag("RedPants")
            || other.CompareTag("RedShirt"))
        {
            wearingRed = true;
            
        }

        if (other.CompareTag("Heels"))
        {
            wearingHeels = true;
        }

    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("BlackDress") || other.CompareTag("BlackSkirt") || other.CompareTag("BlackPants")
            || other.CompareTag("BlackShirt"))
        {
            wearingBlack = false;
            
        }

        if (other.CompareTag("RedDress") || other.CompareTag("RedSkirt") || other.CompareTag("RedPants")
            || other.CompareTag("RedShirt"))
        {
            wearingRed = false;
         
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (wearingBlack || wearingRed || wearingHeels)
        {
            ReactionHappy.SetActive(true);
        }
        else
        {
            ReactionHappy.SetActive(false);
        }

    }
}
