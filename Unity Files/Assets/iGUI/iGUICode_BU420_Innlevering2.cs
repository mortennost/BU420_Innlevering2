using UnityEngine;
using System.Collections;
using iGUI;

public class iGUICode_BU420_Innlevering2 : MonoBehaviour
{
	[HideInInspector]
	public iGUIDropDownList dropDownList2;
	[HideInInspector]
	public iGUIButton button2;
	[HideInInspector]
	public iGUIDropDownList dropDownList1;
	[HideInInspector]
	public iGUITextfield textfield1;
	[HideInInspector]
	public iGUILabel label2;
	[HideInInspector]
	public iGUIButton button1;
	[HideInInspector]
	public iGUILabel label1;
	[HideInInspector]
	public iGUIListBox listBox1;
	[HideInInspector]
	public iGUIPanel panelStatistics;
	[HideInInspector]
	public iGUIPanel panelMenu;
	[HideInInspector]
	public iGUIPanel panelProfile;
	[HideInInspector]
	public iGUITabPanel tabPanelMain;
	[HideInInspector]
	public iGUIRoot root;

	static iGUICode_BU420_Innlevering2 instance;
	
	void Awake()
	{
		instance=this;
	}
	
	public static iGUICode_BU420_Innlevering2 getInstance()
	{
		return instance;
	}

}
