﻿namespace LateStartStudio.Hero6
{
    using System;
    using System.Diagnostics;
    using Eto.Forms;
    using Eto.Serialization.Xaml;

    public class CrashDialog : Form
    {
        private readonly Exception exception;
        private readonly LinkButton emailLink;

        public CrashDialog(Exception exception)
        {
            XamlReader.Load(this);

            this.exception = exception;
            this.emailLink = this.FindChild<LinkButton>("EmailLink");

            this.FindChild<LinkButton>("FilenameLink").Text = Game.Logger.Filename;
            this.FindChild<Label>("CrashMessage").Text = exception.Message;
        }

        public void FilenameLinkClick(object sender, EventArgs e)
        {
            Process.Start(Game.Logger.Filename);
        }

        public void ForumLinkClick(object sender, EventArgs e)
        {
            Process.Start("http://www.hero6.org/forum/");
        }

        public void BugTrackerLinkClick(object sender, EventArgs e)
        {
            Process.Start("https://github.com/LateStartStudio/Hero6/issues");
        }

        public void EmailLinkClick(object sender, EventArgs e)
        {
            Process.Start($"mailto:{this.emailLink.Text}?subject=Hero6 Crash&body={"Hero6 has crashed\n\n" + this.exception}");
        }
    }
}
