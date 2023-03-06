using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FailMushroom : MonoBehaviour
{
    CounterController counterController;

    // Start is called before the first frame update
    void Start()
    {
        counterController = GameObject.Find("Manager").GetComponent<CounterController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name=="Boy")
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("fail");
            counterController.IncrementCounter();
        }
    }
}
