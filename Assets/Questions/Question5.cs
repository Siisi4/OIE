using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Question5 : MonoBehaviour
{
    public TMP_Text questiontext5;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Question 5 affichée.");

            // activé la question sur l'écran 
            // chercher la sauvegarde
            Quest5();
        }
    }

    // la question s'affiche en boucle, après avoir quitter 



    // Définir les slots mémoires à aller chercher 

    public void Quest5()
    {
        questiontext5.text = PlayerPrefs.GetString("Case5", "Pas de question choisie");
    }
}
