using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gear : MonoBehaviour {

    public GameObject greasy;
    Rigidbody2D rgbdGear;
    float gearScroll = 4;

    void Start() {
        rgbdGear = GetComponent<Rigidbody2D>();
    }

   
    void Update() {

        rgbdGear.velocity = new Vector2(0, gearScroll);

        if (rgbdGear.position.y > 12)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Player") {
            Instantiate(greasy, new Vector3(rgbdGear.position.x, rgbdGear.position.y, 0), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
