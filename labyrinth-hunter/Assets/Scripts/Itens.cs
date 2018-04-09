using System.Collections; using System.Collections.Generic; using UnityEngine; using UnityEngine.SceneManagement;

public class Itens : MonoBehaviour {      //List<GameObject> itens;     int itensCounter = 10;      // Use this for initialization     void Start () {         //itens = GameObject.FindGameObjectWithTag("Item");     } 	 	// Update is called once per frame 	void Update () {

    }      void OnTriggerEnter(Collider other) {         other.gameObject.SetActive(false);
        itensCounter = itensCounter - 1;         print("Faltam: "+ itensCounter);                 if (itensCounter == 0)
        {
            SceneManager.LoadScene("WinScreen");
        }     } }