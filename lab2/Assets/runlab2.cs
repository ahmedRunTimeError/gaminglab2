using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runlab2 : MonoBehaviour
{
    public float move ;
    public float jumb ;
    public keycode spacebar;
     public keycode L;
    public keycode R;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(spacebar))  {
        jumb();
    
      }

      if(Input.GetKey(L))  {
        GetComponate <Rigidbody 2D>.velocity =new vectour2(-move,   GetComponate <Rigidbody 2D>.velocity.y)
    
      }

if(Input.GetKey(R))  {
        GetComponate <Rigidbody 2D>.velocity =new vectour2(-move,   GetComponate <Rigidbody 2D>.velocity.y)
    
      }










    }
}
