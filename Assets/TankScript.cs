using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScript : MonoBehaviour
{
    public GameObject explosion;
    public Transform position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if(col.gameObject.tag.Equals("Bullet"))
        {
            Instantiate(explosion, position.position, position.rotation);
            Destroy(col.gameObject);
            Destroy(gameObject);
            
        }
    }
}
