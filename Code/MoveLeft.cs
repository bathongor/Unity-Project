using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {

    [SerializeField]
    private float _speed = 5f;
    [SerializeField]
    private bool _randomizeHeight = true;
    [SerializeField]
    private bool _randomizeWidth = true;

    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.left * Time.deltaTime* _speed);
        
        if (transform.position.x < -15)
        {

            if (_randomizeHeight)
            {
                float randomYPosition = UnityEngine.Random.Range(-1, 1);
                transform.position = new Vector3(15, randomYPosition, 0);  
            }
            else
            {
                transform.position = new Vector3(15, transform.position.y, 0);
            }

            if (_randomizeWidth)
            {
                float randomXPosition = UnityEngine.Random.Range(15, 50);
                transform.position = new Vector3(randomXPosition, transform.position.y, 0);
            }
        }

        

    }
}
