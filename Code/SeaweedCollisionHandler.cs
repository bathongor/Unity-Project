using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeaweedCollisionHandler : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(0);
        Application.LoadLevel(0);
    }
}
