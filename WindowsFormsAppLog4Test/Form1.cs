using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLog4Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateLog_Click(object sender, EventArgs e)
        {
            LogHelper.WriteLog("执行成功！");
        }

        private void btnCreateExceptionLog_Click(object sender, EventArgs e)
        {
            LogHelper.WriteLog("报了一个错！",new Exception("错误"));
        }

        private void btnRedisTest_Click(object sender, EventArgs e)
        {
            ; ; ;
            Console.WriteLine("Redis写入缓存：zhong");

            RedisCacheHelper.Add("zhong", "zhongzhongzhong", DateTime.Now.AddDays(1));

            Console.WriteLine("Redis获取缓存：zhong");

            string str3 = RedisCacheHelper.Get<string>("zhong");

            Console.WriteLine(str3);

            Console.WriteLine("Redis获取缓存：nihao");
            string str = RedisCacheHelper.Get<string>("nihao");
            Console.WriteLine(str);


            Console.WriteLine("Redis获取缓存：wei");
            string str1 = RedisCacheHelper.Get<string>("wei");
            Console.WriteLine(str1);

            //Console.ReadKey();
        }
    }
}
