using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int pontos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AdicionarPontos(int valor) {
		// Adicionar um ponto a mais ao jogador
		pontos += valor;
	}
}
