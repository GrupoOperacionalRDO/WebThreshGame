using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

namespace UnityTest
{
	
	[TestFixture]
	[Category("SoulBehaviorTests")]
	internal class SoulBehaviorTests
	{
		[Test]
		public void TestDestroySoul(){
			//Preparation
			GameObject soul = GameObject.Instantiate(Resources.Load("Prefabs/Soul")) as GameObject;
			soul.GetComponent<SoulBehavior> ().DestroySoul ();
			Assert.IsTrue (!soul);
			if (soul) {
				GameObject.DestroyImmediate(soul);
			}
		}
	}
}