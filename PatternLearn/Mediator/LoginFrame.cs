using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class LoginFrame : Mediator
    {
        private string title;

        private bool enabled;

        private ColleagueButton buttonOk;
        private ColleagueButton buttonCancel;

        private ColleagueTextField textUser;
        private ColleagueTextField textPass;

        public LoginFrame(string title)
        {
            this.title = title;

            enabled = true;

            CreatColleagues();
        }

        public void CreatColleagues()
        {
            textUser = new ColleagueTextField("Guess");

            textPass = new ColleagueTextField("Login");

            buttonOk = new ColleagueButton("OK");

            buttonCancel = new ColleagueButton("Cancel");

            textUser.SetMediator(this);

            textPass.SetMediator(this);

            buttonOk.SetMediator(this);

            buttonCancel.SetMediator(this);

            Update();
        }

        public void ColleagueChanged()
        {
            enabled = !enabled;

            Update();
        }

        void Update()
        {
            Console.Clear();

            Console.WriteLine(title);

            Console.WriteLine();

            Console.WriteLine("=================================");

            Console.WriteLine();

            textUser.SetColleagueEnabled(enabled);

            textPass.SetColleagueEnabled(enabled);

            buttonOk.SetColleagueEnabled(enabled);

            buttonCancel.SetColleagueEnabled(enabled);
        }
    }
}
