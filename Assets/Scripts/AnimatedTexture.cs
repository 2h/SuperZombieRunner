using UnityEngine;
using System.Collections;

public class AnimatedTexture : MonoBehaviour {

	//Speed of tectures animation
	public Vector2 speed = Vector2.zero;

	//Default offset before scrolling
	private Vector2 offset = Vector2.zero;

	private Material material;

	// Use this for initialization
	void Start () {
		//get reference to the material tied to the background quad
		material = GetComponent<Renderer> ().material;
		
		offset = material.GetTextureOffset("_MainTex");

	}
	
	// Update is called once per frame
	void Update () {
		//increment the offset and re-apply to the material
		offset += speed * Time.deltaTime;

		material.SetTextureOffset("_MainTex",offset);
	}
}
