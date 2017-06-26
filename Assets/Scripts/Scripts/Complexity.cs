using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Complexity : MonoBehaviour {

    public Button complexityButton;
    public int complexity = 1;

	void Start () {
        complexityButton.signalOnClick.AddListener(choseComplexity);
	}
	
	void choseComplexity () {
        //Time.timeScale = 1 + complexity * 3;
        CloseButton.setComplexity(complexity);
	}
}
