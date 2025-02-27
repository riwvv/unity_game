using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player") && healSystem.health < 3){
            healSystem.health += 1;
            Destroy(gameObject);
        }
    }
}
