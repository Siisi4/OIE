using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class QuestionsHit : MonoBehaviour
{
    public TMP_Text questiontext1;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Question 1 affichée.");

            // activé la question sur l'écran 
            // chercher la sauvegarde
            Quest1();
        }
    }

    // Définir les slots mémoires à aller chercher 
    
    public void Quest1()
    {
        questiontext1.text = PlayerPrefs.GetString("Case1", "Pas de question choisie");
    }
    

    
}
