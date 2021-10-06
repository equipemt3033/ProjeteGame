using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger1 : MonoBehaviour
{
    public float timer = 0.5f;
    public int LastScene;
    public bool Corredor = false;
    // Update is called once per frame
    void Update()
    {
        if(timer>=-1)timer -= Time.deltaTime;
        //Limita o contador em -1 para não sobrecarregar o sistema
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(timer <= 0){//Timer pra ganrantir que o player não entre em uma cena e já saia por acidente
            if (other.CompareTag("Lobby")){
                Corredor = false;
                LastScene = 1;
                SceneManager.LoadScene(1);//Carrega a cena do lobby
            }
            if (other.CompareTag("SalaDeJogos")){
                Corredor = false;
                LastScene = 2;
                SceneManager.LoadScene(2);//Carrega a cena da sala de jogos
            }
            if(other.CompareTag("Escritorio")){
                Corredor = false;
                LastScene = 3;
                SceneManager.LoadScene(3);//Carrega a cena do escritório
            }
            if(other.CompareTag("Sala de Jantar")){
                SceneManager.LoadScene(4);//Carrega a cena da sala de jantar
                Corredor = false;
                LastScene = 4;
            }
            if(other.CompareTag("Banheiro")){
                SceneManager.LoadScene(5);//Carrega a cena do banheiro
                Corredor = false;
                LastScene = 5;
            }
            if (other.CompareTag("Biblioteca")){
                SceneManager.LoadScene(6);//Carrega a cena da biblioteca
                Corredor = false;
                LastScene = 6;
            }
            if (other.CompareTag("Cozinha")){
                SceneManager.LoadScene(7);//Carrega cena da cozinha
                Corredor = false;
                LastScene = 7;
            }
            if (other.CompareTag("Piscina")){
                SceneManager.LoadScene(8);//Carrega a cena da piscina
                Corredor = false;
                LastScene = 8;
            }
            if (other.CompareTag("Sala de fora")){
                SceneManager.LoadScene(9);//Carrega a cena de fora
                Corredor = false;
                LastScene = 9;
            }
            if (other.CompareTag("Corredor")){
                SceneManager.LoadScene(10);//Carrega a cena do corredor
                Corredor = true;
            }
        }
    }
}
