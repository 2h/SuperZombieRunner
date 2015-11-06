using UnityEngine;
using System.Collections;

public class TiledBackground : MonoBehaviour {
	
	//Tile Size
	public	int textureSize = 32;
	public bool scaleHorizontally = true;
	public bool scaleVertically = true;
	
	// Use this for initialization
	void Start () {
		
		
		
		var newWidth = !scaleHorizontally ? 1 : Mathf.Ceil(Screen.width / (textureSize * PixelPerfectCamera.scale));
		var newHeight = !scaleVertically ? 1 : Mathf.Ceil(Screen.height / (textureSize * PixelPerfectCamera.scale));
		
		//change size of background quad based on new width and height from above
		
		transform.localScale = new Vector3 (newWidth * textureSize, newHeight * textureSize, 1);
		
		GetComponent<Renderer> ().material.mainTextureScale = new Vector3 (newWidth, newHeight, 1);
	}
}
