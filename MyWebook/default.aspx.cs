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
        const string channelAccessToken = "szHHj+oEk9xaifXctnOSAzYCmbl8zSl9ZchX8umeUrDheBZGlIYypyrvRcDWBampHVOFrSak7odcN9937f3PEO4DtQ+Lhg1TNZGwG5Eer5PURst4U++NglfOIx8uwk/XnPEzwr7xAaJo8Os0rrIxQAdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId= "U6f0f1251d93a2f88ace156d3d2db8b38";

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