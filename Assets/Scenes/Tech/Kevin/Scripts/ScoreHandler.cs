using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour {
    [SerializeField] private TMP_Text myText;
    private int comboCounter;
    private bool comboSuccess;

    // Start is called before the first frame update
    void Start() {
        myText = GetComponent<TMP_Text>();
        Debug.Log("Score timer found!");
    }

    private void HandleComboUI() 
    {
        if (comboSuccess == true) {
            comboCounter++;
            
        }
    }
}
