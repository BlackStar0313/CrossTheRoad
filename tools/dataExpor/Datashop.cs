using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;


[Serializable]
public struct StrDatashop {
	public int idx;
	public string name;
	public int price;
}

[Serializable]
public class Datashop {
	public StrDatashop[] data;
}

