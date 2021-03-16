using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestConfig : MonoBehaviour
{
    public Text _txt;
    public Button _btn;
    // Start is called before the first frame update
    void Start()
    {
        this._txt.text = "点击按钮获取ItemInfo.json的字段配置";
        this._btn.onClick.AddListener(this.OnClick);
    }

    private void OnClick()
    {
        Dictionary<string, ItemInfoConfig> allConfigs = ItemInfoConfig.Instance.getStrDataArray();
        string allNotice = "ItemInfoConfig 一共有:" + allConfigs.Count + "个数据";
        ItemInfoConfig config = ItemInfoConfig.Instance.GetData("gold");
        string funsStr = string.Join(",", config.Funs);
        string valueStr = string.Join(",", config.Values);
        this._txt.text ="IDs:"+config.IDs +  "\nName:" + config.Name + "\nType:" + config.Type + "\nFuns:" + funsStr + "\nValues:" + valueStr + "\n" + allNotice;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
