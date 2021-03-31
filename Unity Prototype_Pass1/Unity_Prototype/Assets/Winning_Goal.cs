using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning_Goal : MonoBehaviour
{
    public FirstPersonAIO Input;
    public GameObject Text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter()
    {
        Input.Stop();
        Text.SetActive(true);
    }
}
