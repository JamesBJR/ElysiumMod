using System;
using System.Linq;
using MelonLoader;
using UnityEngine;
public class ElyMod : MelonMod
{
	private GameObject parentObj;
	private GameObject refrenceObj;

	public override void OnSceneWasLoaded(int buildIndex, string sceneName)

	{
		LoggerInstance.Msg(sceneName + " Loaded");

		void MyDelete(string findObjName)
		{
			refrenceObj = GameObject.Find(findObjName);
			UnityEngine.Object.Destroy(refrenceObj);
			return;
		}
		void MyDeleteAll(string findObjName)
		{
			(from x in Resources.FindObjectsOfTypeAll<GameObject>()
			 where x.name.Equals(findObjName)
			 select x).ToList().ForEach(delegate (GameObject x)
			 {
				 UnityEngine.Object.Destroy(x);
			 });
			return;
		}
		void MyCopyAll(string findObjName)
		{
			(from x in Resources.FindObjectsOfTypeAll<GameObject>()
			 where x.name.Equals(findObjName)
			 select x).ToList().ForEach(delegate (GameObject x)
			 {
				 UnityEngine.Object.Instantiate(x);

			 });
			return;
		}
		void MyCopy(string findObjName)
		{
			refrenceObj = GameObject.Find(findObjName);
			UnityEngine.Object.Instantiate(refrenceObj, refrenceObj.transform.parent);
			return;
		}
		void MyTransform(string findObjName, string newName, Vector3 newPosition, Vector3 newScale, Vector3 newRotation)
		{
			refrenceObj = GameObject.Find(findObjName);
			refrenceObj.name = newName;
			refrenceObj.transform.position = newPosition;
			refrenceObj.transform.eulerAngles = newRotation;
			refrenceObj.transform.localScale = newScale;
			return;

		}
		void MySetParent(string findObjName, string findObjParent)
		{
			refrenceObj = GameObject.Find(findObjName);
			parentObj = GameObject.Find(findObjParent);
			refrenceObj.transform.SetParent(parentObj.transform, true);
			return;
		}
		void MyDeactive(string findObjName)
		{
			refrenceObj = GameObject.Find(findObjName);
			refrenceObj.SetActive(false);
			return;
		}
		//----------------------too do---------------------------------
		void MyActive(string findObjName, int index)
		{
			parentObj = GameObject.Find(findObjName);
			refrenceObj = parentObj.transform.GetChild(index).gameObject;

			
			LoggerInstance.Msg("activateing " + refrenceObj.name);
			refrenceObj.SetActive(true);
			return;

		}



		void MyCreateObject()
		{
			//load from resources folder to current scene
			return;
		}
		void MyLoadObject(string findObjName, string findSceneName)
		{

			return;
		}
		//------------too do---------------------------------------------
		if (sceneName == "Elysium")
		{

			LoggerInstance.Msg("ely loading");
			//-----target, newname, position, scale, rotation
			//--------------------------------------                                    
			MyCopy("Jump Takeoff - 06 Large");
			MyTransform(
				"Jump Takeoff - 06 Large(Clone)",
				"ElyModRightRamp",
				new Vector3(4117.7f, 528.1f, 54.2f),
				new Vector3(1.45f, 1.3271f, 1.4502f),
				new Vector3(90, 295, 0));
			//---------------------------------------
			MyCopy("Jump Takeoff - 06 Large");
			MyTransform(
				"Jump Takeoff - 06 Large(Clone)",
				"ElyModLeftRamp",
				new Vector3(4132.2f, 528.1f, 85.3f),
				new Vector3(1.45f, 1.3271f, 1.4502f),
				new Vector3(90, 295, 0));
			//---------------------------------------
			MyCopy("Jump Takeoff - 06 Large");
			MyTransform(
				"Jump Takeoff - 06 Large(Clone)",
				"ElyModCtrRamp",
				new Vector3(4124.94f, 529.8f, 69.77f),
				new Vector3(1.45f, 2.7271f, 1.4502f),
				new Vector3(90, 295, 0));
			//---------------------------------------
			MyCopy("Jump Takeoff - 06 Large");
			MyTransform(
				"Jump Takeoff - 06 Large(Clone)",
				"ElyModToppipe01",
				new Vector3(3910.443f, 644.2917f, 185.8904f),
				new Vector3(2.63f, 0.3871f, 1.4502f),
				new Vector3(85, 222, 180));
			//---------------------------------------
			MyCopy("Jump Takeoff - 06 Large");
			MyTransform(
				"Jump Takeoff - 06 Large(Clone)",
				"ElyModTopPipe02",
				new Vector3(3931.484f, 643.3306f, 198.1306f),
				new Vector3(2.21f, 0.3871f, 1.4502f),
				new Vector3(85, 222, 358));
			//---------------------------------------
			MyCopy("Jump Takeoff - 06 Large");
			MyTransform(
				"Jump Takeoff - 06 Large(Clone)",
				"ElyModTopPipe01Support",
				new Vector3(3909.502f, 645.6517f, 184.8f),
				new Vector3(2.63f, 0.3871f, 1.4502f),
				new Vector3(70, 222, 180));
			//---------------------------------------
			MyCopy("Jump Takeoff - 06 Large");
			MyTransform(
				"Jump Takeoff - 06 Large(Clone)",
				"ElyModTopRamp03",
				new Vector3(3886.305f, 643.0732f, 158.893f),
				new Vector3(2.63f, 4.4071f, 1.3902f),
				new Vector3(84, 42, 180));
			//---------------------------------------
			MyCopy("Jump Takeoff - 06 Large");
			MyTransform(
				"Jump Takeoff - 06 Large(Clone)",
				"ElyModTopRail01",
				new Vector3(3859.141f, 581.9917f, 149.2097f),
				new Vector3(5.53f, 1.7671f, 15.4302f),
				new Vector3(90, 311, 0));
			//----------------------------------------
			MyCopy("Jump Takeoff - 06 Large");
			MyTransform(
				"Jump Takeoff - 06 Large(Clone)",
				"ElyModMidTable01",
				new Vector3(4013.137f, 537.1747f, 117.7685f),
				new Vector3(3.49f, 1.7671f, 15.4302f),
				new Vector3(90f, 202f, 0f));
			//----------------------------------------
			MyCopy("Jump Takeoff - 06 Large");
			MyTransform(
				"Jump Takeoff - 06 Large(Clone)",
				"ElyModMidTable02",
				new Vector3(4028.911f, 570.6f, 144.7f),
				new Vector3(1.93f, 6.0271f, 6.91f),
				new Vector3(90f, 21f, 0f));
			//----------------------------------------
			MyCopy("Jump Takeoff - 06 Large");
			MyTransform(
				"Jump Takeoff - 06 Large(Clone)",
				"ElyModMidTable02Ramp",
				new Vector3(3994.068f, 589.9f, 112.1489f),
				new Vector3(0.6f, 1.32f, 1.46f),
				new Vector3(88f, 112f, 180f));
			//----------------------------------------
			MyCopy("Jump Takeoff - 06 Large");
			MyTransform(
				"Jump Takeoff - 06 Large(Clone)",
				"ElyModMidTable03",
				new Vector3(4018.797f, 573.3598f, 113.1402f),
				new Vector3(1.45f, 1.4471f, 6.91f),
				new Vector3(90f, 21f, 0f));
			//----------------------------------------
			MyCopy("Jump Takeoff - 06 Large");
			MyTransform(
				"Jump Takeoff - 06 Large(Clone)",
				"ElyModBotQuarter",
				new Vector3(4224.923f, 476.9818f, 32.4399f),
				new Vector3(3.23f, 0.987f, 1.4102f),
				new Vector3(87f, 295f, 0f));
			//----------------------------------------
			MyCopy("Jump Takeoff - 06 Large");
			MyTransform(
				"Jump Takeoff - 06 Large(Clone)",
				"ElyModBotQtrSupport01",
				new Vector3(4228.2f, 479.0217f, 30.9f),
				new Vector3(3.23f, 0.987f, 1.4102f),
				new Vector3(81f, 115f, 180f));
			//----------------------------------------
			MyCopy("Jump Takeoff - 06 Large");
			MyTransform(
				"Jump Takeoff - 06 Large(Clone)",
				"ElyModBotQtrSupport02",
				new Vector3(4231f, 481.0418f, 29.6f),
				new Vector3(3.23f, 0.987f, 1.4102f),
				new Vector3(57f, 115f, 180f));
			//----------------------------------------
			MyCopy("Jump Takeoff - 06 Large");
			MyTransform(
				"Jump Takeoff - 06 Large(Clone)",
				"ElyModBotQtr02Land",
				new Vector3(4252f, 463.6385f, 20f),
				new Vector3(3.39f, 1.987f, 3.1302f),
				new Vector3(81f, 295f, 180f));
			//----------------------------------------
			MyTransform(
			"Flag_540_Mute (11)",
			"Flag_540_Mute (11)",
			new Vector3(4036.18f, 592.5357f, 121.4855f),
			new Vector3(1f, 1f, 1f),
			new Vector3(0f, 196f, 0f));
			//----------------------------------------

			MyDelete("Jump Takeoff - 06 Large");
			MyDeleteAll("JT06 - Paint");
			MyDelete("Jump Takeoff - 05 Large");
			MyDelete("PartyTent (4)");
			MyDelete("AdvertNet2 (5)");
			MyDelete("AdvertNet2 (4)");
			//---------------------------------------



			//---------------------------------------
			//MyDeactive("ElyModTopRamp03");
			//MyActive("Elysium transfer", 20);
			//MyTransform(
			//	"Roller mold 02(2)",
			//	"ElyModRollerTop",
			//	new Vector3(3879.615f, 641.596f, 149.8192f),
			//	new Vector3(88.1398f, 123.5601f, 61.455f),
			//	new Vector3(289, 221, 1));
			//---------------------------------------
		}


		return;
	}
}