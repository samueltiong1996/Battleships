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
	}
}

