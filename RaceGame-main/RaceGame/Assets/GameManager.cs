using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int index;
    public GameObject[] cars;

    void Start()
    {
        index = PlayerPrefs.GetInt("carIndex");
        GameObject car = Instantiate(cars[index], Vector3.zero, Quaternion.identity);    
    }

}   
