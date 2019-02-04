using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content.PM;

namespace Le_Lenny_Face
{
    [Activity(Label = "Click To Copy", ScreenOrientation = ScreenOrientation.Portrait)]
    public class Activity1 : Activity
    {

        //brings resources over 
        Button button1;
        Button button2;
        Button button3;
        Button button4;
        Button button5;
        Button button6;
        Button button7;
        Button button8;
        Button button9;
        Button button10;
        Button button11;
        Button button12;
        Button button13;
        Button button14;
        Button button15;
        Button button16;
        Button button17;
        Button button18;
        Button button19;
        Button button20;
        Button showGenerate;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            
            SetContentView(Resource.Layout.layout1);

            //assigns buttons brought over to a resource ID
            button1 = FindViewById<Button>(Resource.Id.button1);
            button2 = FindViewById<Button>(Resource.Id.button2);
            button3 = FindViewById<Button>(Resource.Id.button3);
            button4 = FindViewById<Button>(Resource.Id.button4);
            button5 = FindViewById<Button>(Resource.Id.button5);
            button6 = FindViewById<Button>(Resource.Id.button6);
            button7 = FindViewById<Button>(Resource.Id.button7);
            button8 = FindViewById<Button>(Resource.Id.button8);
            button9 = FindViewById<Button>(Resource.Id.button9);
            button10 = FindViewById<Button>(Resource.Id.button10);
            button11 = FindViewById<Button>(Resource.Id.button11);
            button12 = FindViewById<Button>(Resource.Id.button12);
            button13 = FindViewById<Button>(Resource.Id.button13);
            button14 = FindViewById<Button>(Resource.Id.button14);
            button15 = FindViewById<Button>(Resource.Id.button15);
            button16 = FindViewById<Button>(Resource.Id.button16);
            button17 = FindViewById<Button>(Resource.Id.button17);
            button18 = FindViewById<Button>(Resource.Id.button18);
            button19 = FindViewById<Button>(Resource.Id.button19);
            button20 = FindViewById<Button>(Resource.Id.button20);
            showGenerate = FindViewById<Button>(Resource.Id.showGenerate);


            //click event that returns us to the main activity
            showGenerate.Click += delegate
            {
                Finish();
            };

            //click events for the other buttons
            button20.Click += Button20_Click;
            button19.Click += Button19_Click;
            button18.Click += Button18_Click;
            button17.Click += Button17_Click;
            button16.Click += Button16_Click;
            button15.Click += Button15_Click;
            button14.Click += Button14_Click;
            button13.Click += Button13_Click;
            button12.Click += Button12_Click;
            button11.Click += Button11_Click;
            button10.Click += Button10_Click;
            button9.Click += Button9_Click;
            button8.Click += Button8_Click;
            button7.Click += Button7_Click;
            button6.Click += Button6_Click;
            button5.Click += Button5_Click;
            button4.Click += Button4_Click;
            button3.Click += Button3_Click;
            button2.Click += Button2_Click;
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button1.Text);

            clipboard.PrimaryClip = clip;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button2.Text);

            clipboard.PrimaryClip = clip;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button3.Text);

            clipboard.PrimaryClip = clip;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button4.Text);

            clipboard.PrimaryClip = clip;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button5.Text);

            clipboard.PrimaryClip = clip;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button6.Text);

            clipboard.PrimaryClip = clip;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button7.Text);

            clipboard.PrimaryClip = clip;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button8.Text);

            clipboard.PrimaryClip = clip;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button9.Text);

            clipboard.PrimaryClip = clip;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button10.Text);

            clipboard.PrimaryClip = clip;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button11.Text);

            clipboard.PrimaryClip = clip;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button12.Text);

            clipboard.PrimaryClip = clip;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button13.Text);

            clipboard.PrimaryClip = clip;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button14.Text);

            clipboard.PrimaryClip = clip;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button15.Text);

            clipboard.PrimaryClip = clip;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button16.Text);

            clipboard.PrimaryClip = clip;
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button17.Text);

            clipboard.PrimaryClip = clip;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button18.Text);

            clipboard.PrimaryClip = clip;
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button19.Text);

            clipboard.PrimaryClip = clip;
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            var clipboard = (ClipboardManager)GetSystemService(ClipboardService);
            var clip = ClipData.NewPlainText(" ", button20.Text);

            clipboard.PrimaryClip = clip;
        }
    }
}