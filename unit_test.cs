using System;
using SwinGameSDK;
using NUnit.Framework;

namespace BattleShips
{
	[TestFixture]
	public class unit_test
	{
		/// <summary>
		/// Tests the mute with m.
		/// “m” is the mute key for the game. If “m” Is pressed, it will mute the game – no music. “p” is the play button. Instead of using the bool _mute from the game controller file, I declared a new string variable, s, to label if the music is still playing after the “m” button is pressed. This is a simpler method rather than needing to write another method to access the _mute property in the other file. The s label can be labelled as anything, “1” or “2”, “on” or “off”, “playing” or “notplaying”. In this case, it will store the string “playing” if it the music is still playing, and store as “notplaying” if the music is not playing.
		/// If the 
		/// assert.areequal (s, “notplaying”); 
		/// is changed to 
		/// assert.areequal (s, “playing”);
		/// the unit test will return as error, because the music is not playing, and the string stored in s is “notplaying”, hence proving that the “m” button works to mute the music.
		/// </summary>
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

