using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healSystem : MonoBehaviour
{
    public static int health;
    public GameObject hp1, hp2, hp3;
    void Start() {
        hp1.SetActive(true);
        hp2.SetActive(true);
        hp3.SetActive(true);
        health = 3;
    }

    void Update() {
        switch(health) {
            case 3:
                hp1.SetActive(true);
                hp2.SetActive(true);
                hp3.SetActive(true);
                break;
            case 2:
                hp1.SetActive(true);
                hp2.SetActive(true);
                hp3.SetActive(false);
                break;
            case 1:
                hp1.SetActive(true);
                hp2.SetActive(false);
                hp3.SetActive(false);
                break;
            case 0:
                hp1.SetActive(false);
                hp2.SetActive(false);
                hp3.SetActive(false);
                break;
        }
    }
}
