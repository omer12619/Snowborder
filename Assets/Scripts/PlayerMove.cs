using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float route;

    Rigidbody2D rdb;
    bool flag =false;
    // Start is called before the first frame update
    void Start()
    {
         rdb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!flag)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rdb.AddTorque(route);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                rdb.AddTorque(-route);
            }
        }



    }
    public void dismove()
    {
        flag= true;
    }
}
