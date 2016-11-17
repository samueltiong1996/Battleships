using System;
using SwinGameSDK;
using NUnit.Framework;

namespace BattleShips
{
	[TestFixture]
	public class unit_test
	{
		[Test]
		public void testMuteWithM ()
		{
			string s;
			SwinGame.PlayMusic("Background");
			SwinGame.KeyTyped (KeyCode.vk_m);
			if (SwinGame.MusicPlaying ()) {
				s = "playing";
			} else {
				s = "notplaying";
			}
			Assert.AreEqual (s, "notplaying");
		}
		
		[Test]
		public void Test_Change_High_score_Page()
		{
			Assert.IsTrue (MenuController.Get_Current_Page == "Menu Page");
		
			MenuController.PerformMainMenuAction (2);

			Assert.IsTrue (MenuController.Get_Current_Page == "High Score Page");
		}
	}
}

