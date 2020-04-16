//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace TDDWorkshop
//{
//    public class CowSay
//    {
//        public Cow CreateCow(string text)
//        {
//            var cow = new Cow();
//            if (text == string.Empty)
//            {
//                text = "Hello World!";
//            }

//            var isPenguin = text.StartsWith("Penguin ");
//            text = RemoveSpeakerFromText(isPenguin, text);
//            cow.Result = CreateBalloon(text);
//            cow.Result.AddRange(CreateSpeaker(isPenguin));

//            return cow;
//        }

//        private string RemoveSpeakerFromText(bool isPenguin, string text)
//        {
//            return isPenguin ? text.Remove(0, 8) : text;
//        }

//        private List<string> CreateSpeaker(bool isPenguin)
//        {
//            return isPenguin ? AddPenguinSpeaker() : AddCowSpeaker();
//        }

//        private List<string> AddCowSpeaker()
//        {
//            return new List<string>
//            {
//                @"         \   ^__^ ",
//                @"          \  (oo)\_____",
//                @"             (__)\       )\/\",
//                @"                 ||----w |",
//                @"                 ||     ||"
//            };
//        }

//        private List<string> AddPenguinSpeaker()
//        {
//            return new List<string>
//            {
//                @"   \    .--.",
//                @"    \  |o_o |",
//                @"       |:_/ |",
//                @"      //   \ \",
//                @"     (|     | )",
//                @"    /'\_   _/`\",
//                @"    \___)=(___/"
//            };
//        }

//        private List<string> CreateBalloon(string text)
//        {
//            var balloon = new List<string>();
//            balloon.Add(AddCharToBaseForLength("  ___", "_", text.Length));
//            AddBalloonText(balloon, text);
//            balloon.Add(AddCharToBaseForLength("  ---", "-", text.Length));

//            return balloon;
//        }

//        private void AddBalloonText(List<string> balloon, string text)
//        {
//            var amountOfLines = (text.Count() + 40 - 1) / 40;

//            if (amountOfLines == 1)
//            {
//                balloon.Add(" < " + text + " >");
//            }
//            else
//            {
//                var lines = new List<string>();
//                for (int i = 0; i < amountOfLines; i++)
//                {
//                    lines.Add(new string(text.Take(40).ToArray()));
//                    if (text.Count() > 40)
//                    {
//                        text = text.Substring(40);
//                    }
//                }

//                balloon.Add(" / " + lines.First() + @" \");
//                lines.Remove(lines.First());

//                var lastLine = lines.Last();
//                lines.Remove(lines.Last());

//                foreach (var line in lines)
//                {
//                    balloon.Add(@" | " + line + @" |");
//                }

//                lastLine = AddCharToBaseForLength(lastLine, " ", 41 - lastLine.Length);
//                balloon.Add(@" \ " + lastLine + @" /");
//            }
//        }

//        private string AddCharToBaseForLength(string startText, string charToAdd, int length)
//        {
//            for (int i = 1; i < length && i < 40; i++)
//            {
//                startText += charToAdd;
//            }

//            return startText;
//        }
//    }
//}