using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour {

    public Button closeB;

    private static int currentComplexity = 1; 

    void close()
    {
        Time.timeScale = currentComplexity;
        InfoPanel.board.destroy();
    }

	void Start () {
        closeB.signalOnClick.AddListener(close);
	}

    public static void setComplexity(int num)
    {
        currentComplexity = num;
    }

}
