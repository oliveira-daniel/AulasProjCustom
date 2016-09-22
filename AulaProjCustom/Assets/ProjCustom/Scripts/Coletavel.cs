using UnityEngine;
using System.Collections;

public class Coletavel : MonoBehaviour {

	public int valorAdicionar;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){

		// Verificar se tocou no jogador
		if (col.tag == "Player") {
			// Acessar a classe Player (como componente)
			Player p = col.GetComponent<Player>();

			// Chamar adicionar pontos
			p.AdicionarPontos(valorAdicionar);

			// Destruir (sumir) o coletavel
			Destroy(gameObject);
		}

	}
}
