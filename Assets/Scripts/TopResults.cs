using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TopResults {//: MonoBehaviour {

    public static ArrayList res = new ArrayList(5);
    static int count = 0;
    //public static SortedList topRated = new SortedList(11);
	// Use this for initialization
	/*void Start () {
        for (int i = 0; i < 11; i++)
            topRated.add(0, 0);
		
	}*/
	
	// Update is called once per frame
	public static void add (int num) {
        if (count < 6)
        {
            res.Add(num);
            count++;
        }
        //topRated.Add(num, 0);
        //topRated.Remove(11);
	}

    /*public static IList getScore()
    {
        return topRated.GetKeyList();
    }*/
}
