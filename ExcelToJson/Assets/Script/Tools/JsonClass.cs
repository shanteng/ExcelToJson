
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using UnityEngine;

public enum JsonKeyType
{
    INT,
    STRING,
}

public class ConfigDefine
{
	public static string ItemInfo = "ItemInfo";
}


public class ItemInfoConfig : Config<ItemInfoConfig>
{
	public string Name;
	public int Type;
	public int[] Funs;
	public string[] Values;
	public ItemInfoConfig() : base(ConfigDefine.ItemInfo,JsonKeyType.STRING) { }
}















