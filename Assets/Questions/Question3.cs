using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Question3 : MonoBehaviour
{
    public TMP_Text questiontext3;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Question 3 affichée.");

            // activé la question sur l'écran 
            // chercher la sauvegarde
            Quest3();
        }
    }

    // la question s'affiche en boucle, après avoir quitter 



    // Définir les slots mémoires à aller chercher 

    public void Quest3()
    {
        questiontext3.text = PlayerPrefs.GetString("Case3", "Pas de question choisie");
    }
}
