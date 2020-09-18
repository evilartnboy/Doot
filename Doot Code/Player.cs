using UnityEngine.Networking;
using UnityEngine;
using TMPro;

public class Player : NetworkBehaviour
{
	public int speed;
	public int jumppower;
	public float jetpack;
	public bool flying;
	public GameObject camera;
	public float doot;
	public bool candoot;
	public GameObject dootmask;
	public GameObject dootfill;
	public bool redteam;
	public bool blueteam;
	public int volume;
	public new string name;
	public TMP_InputField tmpInputField;
	public TextMeshPro hovername;
	public bool facingleft;
	public bool knockedback;
}
