//using System;
//using System.Collections.Generic;

//namespace TDDWorkshop
//{
//    public class CowSay
//    {
//        public Cow CreatCow(string text)
//        {
//            var cow = new Cow();
//            if (text == string.Empty)
//            {
//                text = "Hello World!";
//            }

//            cow.Result = CreateBalloon(text);
//            cow.Result.AddRange(CreateSpeaker());

//            return cow;
//        }

//        private List<string> CreateSpeaker()
//        {
//            var speaker = new List<string>();
//            speaker.Add(@"         \   ^__^ ");
//            speaker.Add(@"          \  (oo)\_____");
//            speaker.Add(@"             (__)\       )\/\");
//            speaker.Add(@"                 ||----w |");
//            speaker.Add(@"                 ||     ||");

//            return speaker;
//        }

//        private List<string> CreateBalloon(string text)
//        {
//            var balloon = new List<string>();
//            balloon.Add("  ______________");
//            balloon.Add(" < " + text + " >");
//            balloon.Add("  --------------");

//            return balloon;
//        }
//    }
//}