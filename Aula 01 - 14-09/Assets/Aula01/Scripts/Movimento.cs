using UnityEngine;
using System.Collections;

public class Movimento : MonoBehaviour {

	// Soma da posicao
	float soma = 0.2f;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		// Armazenar a posiçao atual
		Vector2 posicao = transform.position;

		// Verificar a posiçao
		if (transform.position.x > 5f ||
		    transform.position.x < -5f) {
			soma *= -1;
		}

		// Mover a sprite
		transform.position = new Vector2 (
			posicao.x + soma,
			posicao.y
		);

	}
}
