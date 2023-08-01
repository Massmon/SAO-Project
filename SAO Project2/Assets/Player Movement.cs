using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    [SerializeField] private float _speed = 1;
    [SerializeField] private Rigidbody _rb;
    void Update()
    {
        var dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _rb.velocity = dir * _speed;
      //  transform.Translate(dir * _speed * Time.deltaTime);
      //  if (Input.GetKeyDown(KeyCode.W)) transform.Translate(Vector3.forward);
       // if (Input.GetKeyDown(KeyCode.A)) transform.Translate(Vector3.right);
       // if (Input.GetKeyDown(KeyCode.S)) transform.Translate(Vector3.back);
       // if (Input.GetKeyDown(KeyCode.D)) transform.Translate(Vector3.left);
    }
}
