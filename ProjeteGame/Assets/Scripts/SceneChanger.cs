using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public float timer = 3f;
    // Update is called once per frame
    void Update()
    {
        if(timer>=-1)timer -= Time.deltaTime;
        //Limita o contador em -1 para não sobrecarregar o sistema
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(timer <= 0){//Timer pra ganrantir que o player não entre em uma cena e já saia por acidente
            if (other.CompareTag("Lobby")){
                SceneManager.LoadScene(1);//Carrega a cena do lobby
            }
            if (other.CompareTag("SalaDeJogos")){
                SceneManager.LoadScene(2);//Carrega a cena da sala de jogos
            }
            if(other.CompareTag("Escritorio")){
                SceneManager.LoadScene(3);//Carrega a cena do escritório
            }
            if(other.CompareTag("Sala de Jantar")){
                SceneManager.LoadScene(4);//Carrega a cena da sala de jantar
            }
            if(other.CompareTag("Corredor")){
                SceneManager.LoadScene(5);//Carrega a cena do corredor
            }
        }
    }
}
