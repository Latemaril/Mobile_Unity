using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLab3 : MonoBehaviour
{
    public GameObject bullet;
    public GameObject player;
    
    
    private Vector3 _playerPosition;
    private Vector3 _dir;

    public int _hitCount;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Shut");

            _playerPosition = player.transform.position;
            _dir = player.transform.TransformDirection(Vector3.forward);

            GameObject cube =  Instantiate(bullet, _playerPosition, Quaternion.identity);
            
            cube.GetComponent<Rigidbody>().AddForce(_dir * 1000);
            Destroy(cube, 2.0f);
        }
    }
    
}
