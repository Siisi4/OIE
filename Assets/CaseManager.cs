﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CaseManager : MonoBehaviour
{
    // Chaque bouton d'enregistrement pour les questions choisies :
    
    public TMP_Text Case1;
    public TMP_Text Case2;
    public TMP_Text Case3;
    public TMP_Text Case4;
    public TMP_Text Case5;
    public TMP_Text Case6;
    public TMP_Text Case7;
    public TMP_Text Case8;
    public TMP_Text Case9;
    public TMP_Text Case10;
    public TMP_Text Case11;
    public TMP_Text Case12;
    public TMP_Text Case13;
    public TMP_Text Case14;
    public TMP_Text Case15;
    public TMP_Text Case16;
   
    // On sauvegarde chaque question dans une case mémoire 

    public void SaveCase1()
    {
        PlayerPrefs.SetString("Case1", Case1.text);
        Debug.Log("Question 1 enregistrée à la case mémoire 1 : " + Case1.text);
    }

    public void SaveCase2()
    {
        PlayerPrefs.SetString("Case2", Case2.text);
        Debug.Log("Question enregistrée à la case mémoire 2 : " + Case2.text);
    }

    public void SaveCase3()
    {
        PlayerPrefs.SetString("Case3", Case3.text);
        Debug.Log("Question enregistrée à la case mémoire 3 : " + Case3.text);
    }
    public void SaveCase4()
    {
        PlayerPrefs.SetString("Case4", Case4.text);
        Debug.Log("Question enregistrée à la case mémoire 4 : " + Case4.text);
    }
    public void SaveCase5()
    {
        PlayerPrefs.SetString("Case5", Case5.text);
        Debug.Log("Question enregistrée à la case mémoire 5 : " + Case5.text);
    }
    public void SaveCase6()
    {
        PlayerPrefs.SetString("Case6", Case6.text);
        Debug.Log("Question enregistrée à la case mémoire 6 : " + Case6.text);
    }
    public void SaveCase7()
    {
        PlayerPrefs.SetString("Case7", Case7.text);
        Debug.Log("Question enregistrée à la case mémoire 7 : " + Case7.text);
    }
    public void SaveCase8()
    {
        PlayerPrefs.SetString("Case8", Case8.text);
        Debug.Log("Question enregistrée à la case mémoire 8 : " + Case8.text);
    }
    public void SaveCase9()
    {
        PlayerPrefs.SetString("Case9", Case9.text);
        Debug.Log("Question enregistrée à la case mémoire 9 : " + Case9.text);
    }
    public void SaveCase10()
    {
        PlayerPrefs.SetString("Case10", Case10.text);
        Debug.Log("Question enregistrée à la case mémoire 10 : " + Case10.text);
    }
    public void SaveCase11()
    {
        PlayerPrefs.SetString("Case11", Case11.text);
        Debug.Log("Question enregistrée à la case mémoire 11 : " + Case11.text);
    }
    public void SaveCase12()
    {
        PlayerPrefs.SetString("Case12", Case12.text);
        Debug.Log("Question enregistrée à la case mémoire 12 : " + Case12.text);
    }
    public void SaveCase13()
    {
        PlayerPrefs.SetString("Case13", Case13.text);
        Debug.Log("Question enregistrée à la case mémoire 13 : " + Case13.text);
    }
    public void SaveCase14()
    {
        PlayerPrefs.SetString("Case14", Case14.text);
        Debug.Log("Question enregistrée à la case mémoire 14 : " + Case14.text);
    }
    public void SaveCase15()
    {
        PlayerPrefs.SetString("Case15", Case15.text);
        Debug.Log("Question enregistrée à la case mémoire 15 : " + Case15.text);
    }
    public void SaveCase16()
    {
        PlayerPrefs.SetString("Case16", Case16.text);
        Debug.Log("Question enregistrée à la case mémoire 16 : " + Case16.text);
    }
}
