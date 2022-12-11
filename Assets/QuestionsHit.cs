using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class QuestionsHit : MonoBehaviour
{
    public GameObject questiontext1;

    void OnTriggerStay2D(Collider2D other){
        if (other.CompareTag("Player"))
        {
            Debug.Log("Question 1 affichée.");
            questiontext1.SetActive(true);

        }    
    }

    
}
