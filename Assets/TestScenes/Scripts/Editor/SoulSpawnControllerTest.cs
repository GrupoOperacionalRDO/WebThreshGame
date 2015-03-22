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
	[Category("SoulSpawnControllerTests")]
	internal class SoulSpawnControllerTests
	{
		[Test]
		public void TestSoulSpawn(){
			GameObject camera = GameObject.Instantiate(Resources.Load("Prefabs/MainCamera")) as GameObject;
			float z = UnityEngine.Random.Range (-4.5F, 8F);
			float x = UnityEngine.Random.Range (-10.0F, -8.0F);
			GameObject soul = camera.GetComponent<SoulSpawnController> ().spawnSoul (x, z);
			Assert.IsTrue (soul);
			if (soul) {
				GameObject.DestroyImmediate(soul);
			}
			GameObject.DestroyImmediate (camera);
		}
	}
}