using UnityEngine;
using System.Collections;

public class MovimentoTeclado : MonoBehaviour {

	public float velocidade;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		// Vincular o componente
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		// Movimentar usando as fisicas da unity
		// rb.velocity = Vector2.left * velocidade;
		rb.velocity = new Vector2(
			Input.GetAxis("Horizontal") * velocidade,
			Input.GetAxis("Vertical") * velocidade
		);



	}
}
