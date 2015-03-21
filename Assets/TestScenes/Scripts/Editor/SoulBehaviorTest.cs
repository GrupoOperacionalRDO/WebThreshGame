/**	HUDControllerTest.cs
 *  @author: Artur Nista
 *   
 *	Utilizado para testar os métodos do SoulBehavior.
 *
 */

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
	internal class SoulBehaviorTest
	{
		[Test]
		public void TestCollide(){
			//Preparation
			GameObject scenario = GameObject.Instantiate(Resources.Load("Prefabs/PreScenario")) as GameObject;
			GameObject soul = GameObject.Instantiate(Resources.Load("Prefabs/Soul"), new Vector3(5, 5, 0), Quaternion.identity) as GameObject;
			//Action

			//Assertion
			//Assert.That(hud.GetComponentInChildren<UnityEngine.UI.Text>().text,Is.EqualTo("Score: " + randomScore.ToString()));
			//GameObject.DestroyImmediate (soul);
			GameObject.DestroyImmediate (scenario);
		}
		
	}
}