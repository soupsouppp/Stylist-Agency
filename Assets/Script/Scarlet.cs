using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scarlet : MonoBehaviour
{
    public GameObject ReactionHappy;
    public GameObject ReactionUnhappy;
    public GameObject ReactionShy;
    public GameObject ReactionQuestion;

    public bool Like;
    public bool Dislike;
    public bool Question;
    public bool Shy;


    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("ScarletLike"))
        {
            Like = true;
        }

        if (other.CompareTag("ScarletDislike"))
        {
            Dislike = true;
        }

        if (other.CompareTag("ScarletHuh"))
        {
            Question = true;
        }

        if (other.CompareTag("ScarletShy"))
        {
            Shy = true;
        }

    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("ScarletLike"))
        {
            Like = false;
        }

        if (other.CompareTag("ScarletDislike"))
        {
            Dislike = false;
        }

        if (other.CompareTag("ScarletHuh"))
        {
            Question = false;
        }

        if (other.CompareTag("ScarletShy"))
        {
            Shy = false;
        }

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Like)
        {
            ReactionHappy.SetActive(true);
        }
        else
        {
            ReactionHappy.SetActive(false);
        }


        if (Dislike)
        {
            ReactionUnhappy.SetActive(true);
        }
        else
        {
            ReactionUnhappy.SetActive(false);
        }

        if (Question)
        {
            ReactionQuestion.SetActive(true);
        }
        else
        {
            ReactionQuestion.SetActive(false);
        }

        if (Shy)
        {
            ReactionShy.SetActive(true);
        }
        else
        {
            ReactionShy.SetActive(false);
        }
    }
}
