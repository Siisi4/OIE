using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Question4 : MonoBehaviour
{
    public TMP_Text questiontext4;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Question 4 affichée.");

            // activé la question sur l'écran 
            // chercher la sauvegarde
            Quest4();
        }
    }

    // la question s'affiche en boucle, après avoir quitter 



    // Définir les slots mémoires à aller chercher 

    public void Quest4()
    {
        questiontext4.text = PlayerPrefs.GetString("Case4", "Pas de question choisie");
    }
}
