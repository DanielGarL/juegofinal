using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool onGround;
    public float fuerza_x;
    public float fuerza_y;
    public float fuerza_z;

    // Start is called before the first frame update
    void Start()
    {
       onGround = false; 
       fuerza_x=0;
       fuerza_y=0;
       fuerza_z=0;
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
        print("Space key was released");
      if (GetComponent<Rigidbody>() != null)
      {
        GetComponent<Rigidbody>().useGravity = true;
      }
        }
      if(Input.GetKeyDown(KeyCode.F))
      {
      if (onGround){
        Vector3 fuerza = new Vector3(fuerza_x, fuerza_z, fuerza_y);
        GetComponent<Rigidbody>().AddForce(fuerza);
      }
      }
      if(Input.GetKeyDown(KeyCode.Z))
      {
         fuerza_x = fuerza_x - 50;
      }
      if(Input.GetKeyDown(KeyCode.X))
      {
        fuerza_x = fuerza_x + 50;
      }

      if(Input.GetKeyDown(KeyCode.Q))
      {
         fuerza_y = fuerza_y - 50;
      }
      if(Input.GetKeyDown(KeyCode.E))
      {
        fuerza_y = fuerza_y + 50;
      }

      if(Input.GetKeyDown(KeyCode.J))
      {
         fuerza_z = fuerza_z - 50;
      }
      if(Input.GetKeyDown(KeyCode.U))
      {
        fuerza_z = fuerza_z + 50;
      }




    

    }
    private void OnCollisionEnter(Collision c){
        Debug.Log("colision");
        onGround = true;
    }
      private void OnCollisionStay(Collision c){
        onGround = true;
    }
      private void OnCollisionExit(Collision c){
        onGround = false;
        Debug.Log("Libre");
    }
}
