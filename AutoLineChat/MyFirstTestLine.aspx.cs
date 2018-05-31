using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutoLineChat
{
    public partial class MyFirstTestLine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("szHHj+oEk9xaifXctnOSAzYCmbl8zSl9ZchX8umeUrDheBZGlIYypyrvRcDWBampHVOFrSak7odcN9937f3PEO4DtQ+Lhg1TNZGwG5Eer5PURst4U++NglfOIx8uwk/XnPEzwr7xAaJo8Os0rrIxQAdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage("U6f0f1251d93a2f88ace156d3d2db8b38", "test");
            bot.PushMessage("U6f0f1251d93a2f88ace156d3d2db8b38", 4, 613);
            bot.PushMessage("U6f0f1251d93a2f88ace156d3d2db8b38", new Uri("https://hk.entertainment.appledaily.com/entertainment/daily/article/20151128/19390825"));
        }
    }
}