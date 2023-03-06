using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterController : MonoBehaviour
{
    public int heart;
    Text counterView;
    // Start is called before the first frame update
    void Start()
    {
        ResetCounter();
    }

    public void IncrementCounter()
    {
        heart--;
        GameObject.Find("Text").GetComponent<Text>().text = heart.ToString();
    }

    public void ResetCounter()
    {
        heart=5;
        GameObject.Find("Text").GetComponent<Text>().text = heart.ToString();
    }
}
