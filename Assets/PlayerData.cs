using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Player Data")]
public class PlayerData : ScriptableObject
{
	public float WalkSpeed;
	public float RunSpeed;
	public float RotationSensitivity;
}
