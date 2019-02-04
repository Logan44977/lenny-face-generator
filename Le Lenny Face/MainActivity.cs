using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;

namespace Le_Lenny_Face
{
    [Activity(Label = "Lenny Face Generator", MainLauncher = true, Icon = "@drawable/LennyFace", ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : Activity
    {
        //creates global variables
        public static string strEarLeft = "(";
        public static string strEarRight = ")";
        public static string strMouth = " ͜ʖ";
        public static string strEyeLeft = " ͡°";
        public static string strEyeRight = " ͡°";


        //brings resources here
        Button showPremade;
        Button earsButton;
        Button mouthButton;
        Button eyesButton;
        Button randomButton;
        Button copyButton;
        TextView textview1;



        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            earsButton = FindViewById<Button>(Resource.Id.earsButton);
            mouthButton = FindViewById<Button>(Resource.Id.mouthButton);
            eyesButton = FindViewById<Button>(Resource.Id.eyesButton);
            randomButton = FindViewById<Button>(Resource.Id.randomButton);
            textview1 = FindViewById<TextView>(Resource.Id.textView1);
            copyButton = FindViewById<Button>(Resource.Id.copyButton);
            showPremade = FindViewById<Button>(Resource.Id.showPremade);


            //Click events
            earsButton.Click += earsClick;
            mouthButton.Click += mouthClick;
            eyesButton.Click += eyesClick;
            randomButton.Click += randomClick;
            copyButton.Click += copyClick;

            //changes the layout           
            showPremade.Click += delegate
            {
                var intent = new Intent(this, typeof(Activity1));
                StartActivity(intent);
            };
        }

        void earsClick(object sender, EventArgs e)
        {
            //declares a random number
            int RandomNumber;
            //creates a random number generation process
            Random randEar = new Random();
            RandomNumber = randEar.Next(1, 26);


            //creates an array for the left ear. Xamarin does not support multi-dimensional arrays 
            var LeftEar = new string[] { "q", "ʢ", "⸮","ʕ","(","[","¯\\_","୧","୨","☞",
               "ヽ(","\\(","乁(","└[","(づ","(ง","|", "ᖗ", "ᕦ", "ᕦ(", "ᕙ(","ᘳ","ᕮ","ᕳ",/*"⤜"*/"ᑫ","ᑴ",};
            //creates an array for the right ear
            var RightEar = new string[] {"p","ʡ","?","ʔ",")","]","_/¯","୨","୧","☞"
          ,")ﾉ", ")/", ")ㄏ","]┘", ")づ",")ง","|", "ᖘ", "ᕥ",")ᕥ", ")ᕗ", "ᘰ", "ᕭ", "ᕲ", "ᑷ", "ᑷ"};

            //assigns the array element to the left & right ear variables
            strEarLeft = LeftEar[RandomNumber];
            strEarRight = RightEar[RandomNumber];

            //Assigns the variables to the text large resource and puts it in the middle
            textview1.Text = strEarLeft + strEyeLeft + strMouth + strEyeRight + strEarRight;
            textview1.TextAlignment = TextAlignment.Center;
        }

        void mouthClick(object sender, EventArgs e)
        {
            //declares a random number
            int RandomNumber;
            //creates a random number generation process
            Random randMouth = new Random();
            RandomNumber = randMouth.Next(1, 42);

            //creates a mouth array 
            var MouthString = new string[] { "v", "ᴥ", "ᗝ", "Ѡ", "ᗜ", "Ꮂ", "ᨓ", "ᨎ", "ヮ ]", "╭͜ʖ╮", " ͟ل͜", " ͜ʖ", " ͟ʖ", " ʖ̯",
                "ω", " ³ ", " ε ", "﹏", "□", "ل͜", "‿", "╭╮", "‿‿", "▾", "‸", "Д", "∀", "!", "人", ".", "ロ", "_", "෴", "ꔢ",
                "ѽ", "ഌ", "⏠", "⏏", "⍊", "⍘", "ツ", "益" };

            //assigns the array element to the mouth variable
            strMouth = MouthString[RandomNumber];

            //Assigns the variables to the text large resource
            textview1.Text = strEarLeft + strEyeLeft + strMouth + strEyeRight + strEarRight;
            textview1.TextAlignment = TextAlignment.Center;
        }
        void eyesClick(object sender, EventArgs e)
        {
            int RandomNumber;
            //creates a random number generation process
            Random randEye = new Random();
            RandomNumber = randEye.Next(1, 92);

            //creates an eyes array
            var Lefteye = new string[]  {"⌐■"," ͠°","⇀","´•","´","`","ó","ò","⸌",">","Ƹ̵̡ ","ᗒ","⟃","⪧","⪦","⪩","⪨","⪰","⫑","⨴","⩿","⩾","⩺","⩹","◥▶","≋", "૦ઁ"," ͯ ",
            " ̿ "," ͌ ","ꗞ", "ꔸ", "꘠", "ꖘ","܍", "ළ","◉", "☉","・","▰", "ᵔ", " ﾟ","□","☼","*", "`","⚆","⊜",">","❍","￣","─", "✿","•", "T", "^", "ⱺ", "@", "ȍ", "  ",
            "  ","x","-","$","Ȍ","ʘ","Ꝋ","","","⸟","๏","ⴲ","■"," ﾟ","◕","◔","✧","■","♥"," ͡°","¬"," º ","⨶","⨱","⏓","⏒","⍜","⍤","ᚖ","ᴗ","ಠ","σ" };

            var Righteye = new string[]  {"■","°","↼","•`","`","´","ò","ó","⸍","<","Ʒ","ᗕ","⟄","⪦","⪧","⪨","⪩","⪯","⫒","⨵","⪀","⩽","⩹","⩺","◀◤","≋","૦ઁ"," ͯ ",
            " ̿ "," ͌ ","ꗞ", "ꔸ","꘠","ꖘ","܍","ළ","◉","☉","・","▰","ᵔ"," ﾟ","□","☼","*","`","⚆","⊜",">","❍","￣","─","✿","•","T","^","ⱺ","@","ȍ","  ","  ","x","-","$","Ȍ",
            "ʘ","Ꝋ","","","⸟","๏","ⴲ","■"," ﾟ","◕","◔","✧","■","♥"," ͡°","¬"," º ","⨶","⨱","⏓","⏒","⍜","⍤","ᚖ","ᴗ","ಠ","σ"};

            //assigns the array element to the eye variables
            strEyeLeft = Lefteye[RandomNumber];
            strEyeRight = Righteye[RandomNumber];

            //Assigns the variables to the text large resource
            textview1.Text = strEarLeft + strEyeLeft + strMouth + strEyeRight + strEarRight;
            textview1.TextAlignment = TextAlignment.Center;
        }

        void randomClick(object sender, EventArgs e)
        {
            //calls the previous clicks at the same time
            eyesClick(sender, e);
            mouthClick(sender, e);
            earsClick(sender, e);

        }

        void copyClick(object sender, EventArgs e)
        {
            //copies the textview's text to the clipboard
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", textview1.Text);

            clipboard.PrimaryClip = clip;

            Toast.MakeText(this, "Copied To Clipboard", ToastLength.Short).Show();
        }
    }
}

