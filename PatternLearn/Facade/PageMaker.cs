using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class PageMaker
    {
        private PageMaker() { }

        public static void MakeWelcomePage(string mailaddr, string filename)
        {
            Properties2 prop = Database.GetProperties("");
            string username = prop.GetProperty(mailaddr);
            HtmlWriter writer = new HtmlWriter(filename);
            writer.Title("Welcome to " + username + "'s page!");
            writer.Paragraph(username + "欢迎来到" + username + " 的主页。");
            writer.Paragraph("等着你的邮件哦！");
            writer.MailTo(mailaddr, username);
            writer.Close();

            Console.WriteLine(filename + " is created for " + mailaddr + " (" + username + ")");
        }

        public static void MakeLinkPage(string filename)
        {
            Properties2 prop = Database.GetProperties("");

            HtmlWriter writer = new HtmlWriter(filename);
            writer.Title("Link page");    

            foreach (var item in prop)
            {
                writer.Link(item.Key, item.Value);
            }

            writer.Close();
            Console.WriteLine(filename + " is created.");
        }
    }
}
