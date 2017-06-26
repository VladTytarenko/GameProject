using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour {

    public Button closeB;

    void close()
    {
        InfoPanel.board.destroy();
    }

	void Start () {
        closeB.signalOnClick.AddListener(close);
	}
}
