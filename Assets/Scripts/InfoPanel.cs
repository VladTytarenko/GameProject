using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InfoPanel : MonoBehaviour
{

    public static InfoPanel board;

    void Start()
    {
        board = this;
    }

    public void destroy()
    {
        Destroy(board.gameObject);
    }
}
