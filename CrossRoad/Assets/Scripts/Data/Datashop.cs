using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;


[Serializable]
public struct StrDatashop {
	public int idx;
	public int price;
	public int role_idx;
}

[Serializable]
public class Datashop {
	public StrDatashop[] data;
}

