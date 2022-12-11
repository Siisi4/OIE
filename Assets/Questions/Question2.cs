using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Question2 : MonoBehaviour
{
    public TMP_Text questiontext2;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Question 2 affichée.");

            // activé la question sur l'écran 
            // chercher la sauvegarde
            Quest2();
        }
    }

    // la question s'affiche en boucle, après avoir quitter 

    

    // Définir les slots mémoires à aller chercher 

    public void Quest2()
    {
        questiontext2.text = PlayerPrefs.GetString("Case2", "Pas de question choisie");
    }
}
