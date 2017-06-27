using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoresLabel : MonoBehaviour {

    public static ScoresLabel points;

    UILabel scoreLabel;

	void Start () {
        points = this;
        scoreLabel = points.GetComponent<UILabel>();
        scoreLabel.text = "000";
        //IList scoreList = TopResults.getScore();
        //int i = TopResults.res.
        //scoreText(TopResults.getScore());
	}
	
	public void scoreText (int num) {
        string newLabel = "";
        int length = num.ToString().Length;
        if (length == 1)
            newLabel = "00" + (num - 1);
        else if (length == 2)
            newLabel = "0" + (num - 1);
        else
            newLabel = "" + (num - 1);
        scoreLabel.text = newLabel;
	}
}
