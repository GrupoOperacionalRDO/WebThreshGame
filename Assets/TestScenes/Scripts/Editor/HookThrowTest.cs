using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

namespace UnityTest
{
	
	[TestFixture]
	[Category("HookThrowTests")]
	internal class HookThrowTests
	{
		[Test]
		public void TestCreateHook(){
			GameObject camera = GameObject.Instantiate(Resources.Load("Prefabs/MainCamera")) as GameObject;
			GameObject.Instantiate(Resources.Load("Prefabs/Thresh"));
			camera.GetComponent<HookThrow> ().createHook ();
			GameObject hook = GameObject.FindGameObjectWithTag ("Hook");
			Assert.IsTrue (hook);
			if (hook) {
				GameObject.DestroyImmediate(hook);
			}
			GameObject.DestroyImmediate (camera);
		}
	}
}