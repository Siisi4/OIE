﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Question8 : MonoBehaviour
{
    public TMP_Text questiontext;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Question 8 affichée.");

            // activé la question sur l'écran 
            // chercher la sauvegarde
            Quest();
        }
    }

    // la question s'affiche en boucle, après avoir quitter 



    // Définir les slots mémoires à aller chercher 

    public void Quest()
    {
        questiontext.text = PlayerPrefs.GetString("Case8", "Pas de question choisie");
    }
}
