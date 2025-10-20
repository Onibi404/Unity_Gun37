
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    [SerializeField] private float _rotateSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        //transform.Translate(new Vector3(0,5,0));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, _speed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -_speed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-_speed, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(_speed, 0, 0) * Time.deltaTime);
        }



        if (Input.GetMouseButton(1))
        {
            transform.Rotate(new Vector3(0, _rotateSpeed, 0) * Time.deltaTime);
        }
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(new Vector3(0,-_rotateSpeed,0) * Time.deltaTime);
        }
        
    }
}
