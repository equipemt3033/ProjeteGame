using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger1 : MonoBehaviour
{
    private float timer = 0.5f;
    public static string LastScene = "Lobby";
    public static bool Corredor = false;
    public static bool Corredor2 = false;
    public static bool SalaDeJogos = false;
    public static bool SalaDeFora = false;
    public static bool Banheiro1 = false;
    public static bool Banheiro2 = false;
    public static bool SalaDeEstar = false;
    public static bool Lobby = false;
    // Update is called once per frame
    void Update()
    {
        if(timer>=-1)timer -= Time.deltaTime;
        //Limita o contador em -1 para não sobrecarregar o sistema
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(timer <= 0){//Timer pra ganrantir que o player não entre em uma cena e já saia por acidente
            if (other.CompareTag("Lobby")){
                if (other.gameObject.layer == 6)
                {
                    Lobby = true;
                }
                SceneManager.LoadScene(1);//Carrega a cena do lobby
                LastScene = "Lobby";
                Corredor = false;
            }
            if (other.CompareTag("SalaDeJogos")){
                SceneManager.LoadScene(2);//Carrega a cena da sala de jogos
                LastScene = "SalaDeJogos";
                Corredor = false;
                SalaDeJogos = true;
                Lobby = false;
            }
            if(other.CompareTag("Escritorio")){
                SceneManager.LoadScene(3);//Carrega a cena do escritório
                LastScene = "Escritorio";
                Corredor = false;
            }
            if(other.CompareTag("Sala de Jantar")){
                SceneManager.LoadScene(4);//Carrega a cena da sala de jantar
                LastScene = "SalaDeJantar";
                Corredor = false;
            }
            if(other.CompareTag("Banheiro")){
                SceneManager.LoadScene(5);//Carrega a cena do banheiro
                LastScene = "Banheiro";
                Corredor = false;
            }
            if (other.CompareTag("Biblioteca")){
                SceneManager.LoadScene(6);//Carrega a cena da biblioteca
                LastScene = "Biblioteca";
                Corredor = false;
            }
            if (other.CompareTag("Cozinha")){
                SceneManager.LoadScene(7);//Carrega cena da cozinha
                LastScene = "Cozinha";
                Corredor = false;
            }
            if (other.CompareTag("Piscina")){
                SceneManager.LoadScene(8);//Carrega a cena da piscina
                LastScene = "Piscina";
                Corredor = false;
            }
            if (other.CompareTag("Sala de fora")){
                SceneManager.LoadScene(9);//Carrega a cena de fora
                LastScene = "SalaDeFora";
                Corredor = false;
                SalaDeFora = true;
            }
            if (other.CompareTag("Corredor")){
                SceneManager.LoadScene(10);//Carrega a cena do corredor
                Corredor = true;
                SalaDeFora = false;
                SalaDeJogos = false;
                Lobby = false;
                SalaDeEstar = false;
            }
            if(other.CompareTag("Sala de estar"))
            {
                if (other.gameObject.layer == 7)
                {
                    SalaDeEstar = true;
                }
                SceneManager.LoadScene(11);//Carrega a cena da sala de estar
                LastScene = "Sala de estar";
                Corredor = false;

                Corredor2 = false;
            }
            if (other.CompareTag("Quarto1"))//Carrega o quarto 1
            {
                SceneManager.LoadScene(12);
                LastScene = "Quarto1"; 
                Corredor2 = false;
            }
            if (other.CompareTag("Quarto2"))//Carrega o quarto 2
            {
                SceneManager.LoadScene(13);

                LastScene = "Quarto2"; 
                Corredor2 = false;
            }
            if (other.CompareTag("Quarto cofre"))//Carrega o quarto 2
            {
                SceneManager.LoadScene(14);
                LastScene = "Quarto cofre";
                Corredor2 = false;
            }
            if (other.CompareTag("Banheiro1"))//Carrega o banheiro 1
            {
                SceneManager.LoadScene(15);
                LastScene = "Banheiro1";
                Banheiro1 = true;
            }
            if (other.CompareTag("Banheiro2"))//Carrega o banheiro 2
            {
                SceneManager.LoadScene(16);
                LastScene = "Banheiro2";
                Banheiro2 = true;
            }
            if (other.CompareTag("Corredor2"))//Carrega o corredor do segundo andar
            {
                SceneManager.LoadScene(17);
                Corredor2 = true;
                Banheiro1 = false;
                Banheiro2 = false;
                SalaDeEstar = false;

            }
        }
    }
}
