using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;


[Serializable]
public struct StrDatarole {
	public int idx;
	public string name;
	public string body_name;
	public string head_name;
}

[Serializable]
public class Datarole {
	public StrDatarole[] data;
}

