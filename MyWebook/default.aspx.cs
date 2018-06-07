using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebook
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "chLuKo3qo6h4SXHNHqLB+uDCQXyMo4QXakpb3pXrjXRTZ7FqZB5sRRZYdWmIzGjfjjwccqFXwUcCIM9DnyL3jOeZ+uQUK41a+MeKuDMaivaam3hSO7NJJlewi4JGAbH6gLtV76XwbGTKXbBWEyLjiQdB04t89/1O/w1cDnyilFU=";

        const string AdminUserId= "Ua8e0bf7c715505b08dc47c6a106b531c";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 1,2);
        }
    }
}