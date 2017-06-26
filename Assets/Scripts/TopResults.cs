using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TopResults {//: MonoBehaviour {

    //private int[] top = new int[10];
    private static SortedList topRated = new SortedList(11);
	// Use this for initialization
	/*void Start () {
        for (int i = 0; i < 11; i++)
            topRated.add(0, 0);
		
	}*/
	
	// Update is called once per frame
	public static void add (int num) {
        topRated.Add(num, 0);
        topRated.Remove(11);
	}

    public IList getScore()
    {
        return topRated.GetKeyList();
    }
}
