using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public static int TheCoin;
    public Text TextCoin;

     void Start()
    {
        TextCoin = GetComponent<Text>();
    }
     void Update()
    {
        TextCoin.text = "" + TheCoin;
    }

}
