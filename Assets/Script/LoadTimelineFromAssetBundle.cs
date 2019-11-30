using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class LoadTimelineFromAssetBundle : MonoBehaviour
{
	private AnimationTrack m_animTrack;
    void OnGUI()
	{
		if(GUI.Button(new Rect(100, 100, 100, 100), "Load UI"))
		{
			var ab = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/newbundle");
			var go = ab.LoadAsset("Cube") as GameObject;
			Instantiate(go, go.transform.position, go.transform.rotation);
		}
	}

}
