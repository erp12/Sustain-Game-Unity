using UnityEngine;
using System.Collections;

public class GUIutils : MonoBehaviour {
	
	private static Texture2D _staticRectTexture;
	private static GUIStyle _staticRectStyle;
	
	// Note that this function is only meant to be called from OnGUI() functions.
	// Taken from http://forum.unity3d.com/threads/draw-a-simple-rectangle-filled-with-a-color.116348/
	public static void GUIDrawRect( Rect position, Color color )
	{
		if( _staticRectTexture == null )
		{
			_staticRectTexture = new Texture2D( 1, 1 );
		}
		
		if( _staticRectStyle == null )
		{
			_staticRectStyle = new GUIStyle();
		}
		
		_staticRectTexture.SetPixel( 0, 0, color );
		_staticRectTexture.Apply();
		
		_staticRectStyle.normal.background = _staticRectTexture;
		
		GUI.Box( position, GUIContent.none, _staticRectStyle );
		
		
	}

	public static int IntLerp (int src, int dest) {
		return (src + dest) / 2;
	}
}
