using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update

    private int i = 3;
    public Renderer rend;
    private int randomNum = -1;
    void Start()
    {
        rend = GetComponent<Renderer>();

        if (tag == "Blue"){
            randomNum = Random.Range(150,251);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"{gameObject.name}:{++i}");
        if(tag == "Red" && i == 100){
            gameObject.SetActive(false);
        }
        if(tag == "Blue" && i == randomNum){
            rend.enabled = false;
        }
    }
}
