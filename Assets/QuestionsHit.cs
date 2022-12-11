using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class QuestionsHit : MonoBehaviour
{
    public GameObject question1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.name == "Question"){
            Debug.Log("Question 1 activé !");
            question1.SetActive(true);
        }

    }
}
