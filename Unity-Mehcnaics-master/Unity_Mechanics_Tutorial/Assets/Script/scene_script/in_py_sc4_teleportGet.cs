using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class in_py_sc4_teleportGet : MonoBehaviour
{
    public GameObject Playertele;
    public float x,y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if(In_py_sc4_teleport.Item==true){
            Playertele.transform.position=new Vector2(x,y);
        }
    }
}