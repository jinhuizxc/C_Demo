using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Demo
{
    class Program
    {
        //定义属性
        private static int i;

        static void Main(string[] args)
        {
            // 继续C#的学习！
            int x;//循环计数变量
            x = 1;//行① 请填写计数变量的初始化语句


            while (x <= 5)//行② 请填写循环条件
            {
                Console.Write("加油！");
                x = x + 1; //行③ 请填写计数变量的自加语句          
            }
            Console.WriteLine();
            // C#算法——求和
            int x1 = 1;
            int sum = 0;//和，初始化为0
            while (x1 <= 30)//循环条件
            {
                if (x1 % 2 != 0)//筛选条件
                    sum += x1;
                x1++;
            }
            Console.WriteLine("1-30奇数的和：" + sum);

            for (x = 1; x < 13; x++)//请填写代码
            {
                Console.WriteLine(x + " ");
            }
            // C#中do…while循环
            int x2 = 2;
            do
            {
                x2++;
                Console.Write(x2 + " "); // 3,4,5
            }
            while (x2 > 2 && x2 <= 4);


        
            for (int c = 1; c <= 6; c ++)//请填写for循环结构
            {
                Console.Write("Yeah!");
            }
            // C#循环结构之continue
            for (int xq = 1; xq < 10; xq++)
            {
                if (xq == 3 || xq == 8)
                    continue;//请添加代码，过滤3和8
                Console.Write(xq);
            }
            Console.WriteLine();
            // C#循环结构之break
            for (x = 1; x <= 5; x++)
            {
                if (x % 2 == 0)
                    continue; //添加关键字break或continue
                Console.Write(x);
            }
            Console.WriteLine();
            // C#循环结构之嵌套循环
            for (int y = 1; y <= 7; y++)
            {
                for (x = 1; x <= y; x++) {
                    Console.Write(x);
                }
                Console.WriteLine();      
            }
            // 输出图案
            for (x = 1; x <= 7; x++)//循环7行
            {
                for (int y = 1; y <= 7; y++)//循环7列
                {
                    if (x == y || x + y == 8)//对角线打印O
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write(".");//其他位置打印.
                    }
                    /**
                     * 上面代码可以简化为2行
                     * string text= x==y||x+y==8 ? "O": ".";
                     * Console.Write(text);
                     * 
                     */
                }
                Console.WriteLine();//换行
            }

            // C#的声明数组和赋值
            int[] age = new int[4];//声明并初始化长度为4的整形数组
            //为数组元素赋值
            age[0] = 18;
            age[1] = 20;
            age[2] = 23;
            age[3] = 17;
            Console.WriteLine("四名同学的年龄是：{0}、{1}、{2}、{3}",
                age[0], age[1], age[2], age[3]);
            // C#访问数组元素
            string[] job = new string[] { "经理", "项目主管", "技术总监", "财务主管" };
            for (int i = 0; i < job.Length; i++)
            {
                Console.Write(job[i] + " ");//打印职位
            }
            Console.WriteLine();
           
            // 算法——查找（一）
            int[] score = new int[] { 89, 39, 100, 51, 94, 65, 70 };//分数
            Console.Write("不及格的有：");
            for (int i = 0; i < score.Length; i++)
            {
                if (score[i] < 60)//筛选条件
                    Console.Write(score[i] + ",");
            }
            Console.WriteLine();
            //练习： 声明整型数组，保存一组整数
            int[] num = new int[] { 3, 34, 42, 2, 11, 19, 30, 55, 20 };
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.Write(num[i] + ",");
                }
            }//请完善代码，循环打印数组中的偶数
            Console.WriteLine();
            // 算法——查找（二）
            int[] score1 = { 85, 34, 98, 100, 20, 60 };//分数
            bool hasNopass = false;//记录是否有不及格的，默认没有
            int index = 0;  // 记录下标
            int number = 0; // 记录不及格人数
            for (int i = 0; i < score1.Length; i++)
            {
                if (score1[i] < 60)//如果有不及格的
                {
                    //记录有不及格的
                    hasNopass = true;
                    index = i;                    
                    number++;                 
                    continue;   // 跳出整个循环
                }             
            }

            if (hasNopass) {
                Console.WriteLine("有" + number + "人不及格");
            }     
            else
                Console.WriteLine("都及格啦！");


            // C#的foreach关键字
             string[] t =new  string[]{"C","Sh","a","rp"};
            // for循环
            for (int i = 0; i < t.Length; i++) {
                Console.Write(t[i] + " ");
            }
            Console.WriteLine();
            //遍历字符串数组t
            foreach (string xv in t)
            {
                Console.Write(xv+ " ");
            }
            Console.WriteLine();

            //声明整型数组，保存一组整数
            int[] numb = new int[] { 3, 34, 43, 2, 11, 19, 30, 55, 20 };
            bool hasSb = false;
            for (int xb = 0; x < numb.Length; x++)
            {
                if (numb[xb] % 7 == 0)
                {
                    hasSb = true;
                    break;
                }
            }
            Console.Write(hasSb ? "有7的整倍数" : "没有7的整倍数");//请完善代码，判断数组中有没有7的整倍数
            Console.WriteLine();

            // C#的二维数组的声明和访问
            char[ ,] ch = { { '我', '是', '软' }, { '件', '工', '程' }, { '师', '啦', '！' } };
            Console.WriteLine("{0}{1}{2}", ch[1, 1], ch[1, 2], ch[2, 0]);


            int[,] scoreA = new int[4, 2] { { 89, 86 }, { 69, 40 }, {64,92 }, {82,100}};
            Console.WriteLine("同学们的分数是:");
            for (int i = 0; i < scoreA.GetLongLength(0); i++)
            {
                Console.WriteLine("语文：{0}，数学{1}", scoreA[i, 0], scoreA[i, 1]);
            }

            // 练习，输出分数最高的同学的姓名和分数
            // 方法一：
            string[,] info = new string[8, 2] { { "吴松", "89" }, { "钱东宇", "90" }, { "伏晨", "98" },
                { "陈陆", "56" }, { "周蕊", "60" }, { "林日鹏", "9" },
                { "A何昆", "93" }, { "关欣", "85" } };

            string name = "", scoreB = "0";
            for (int i = 0; i < 8; i++)
            {
                if (String.Compare(info[i, 1], scoreB) > 0)
                {
                    name = info[i, 0];
                    scoreB = info[i, 1];
                }
            }
            Console.WriteLine("分数最高的是" + name + ",分数是" + scoreB);
            // 方法二：
            string[] name2 = new string[] {"吴松", "钱东宇", "伏晨","陈陆", "周蕊", "林日鹏", "A何昆", "关欣"};
            int [] score2 = new int[] { 89, 90, 98, 56, 60, 91, 93, 85 };
            int k = 0;   // 定义下标
            int max = score2[0];  // 定义最大值
            for (i = 1; i < score2.Length; i++)
            {
                if (score2[i] > max)
                {
                    max = score2[i];
                    k = i;
                }
            }
            Console.WriteLine("分数最高的是{0}，分数是{1}", name2[k], score2[k]);
            
            // 3、获取平均分以及高于平均分的学生
            // 方法一
            string[] name3 = new string[] { "景珍", "林惠洋", "成蓉", "洪南昌", "龙玉民", "单江开", "田武山", "王三明" };
            int[] score3 = new int[] { 90, 65, 88, 70, 46, 81, 100, 68 };

            int sum3 = 0, avg3;
            for (int i = 0; i < score3.Length; i++) {
                sum3 += score3[i];                      
            }

            avg3 = sum3 / score3.Length;
            Console.Write("平均分是" + avg3 + ", 高于平均分的是: \n"); // avg3 = 76
            // 计算高于平均分的名字
            for (int i = 0; i < score3.Length; i++)
            {
                if (score3[i] > avg3)
                {
                    Console.Write(name3[i] + '\t');
                }
            }

            Console.WriteLine();

            // 方法二
            string[,] info2 = new string[8, 2] { { "景珍", "90" }, { "林惠洋", "65" }, { "成蓉", "88" }, { "洪南昌", "70" }, 
                { "龙玉民", "46" }, { "单江开", "81" }, { "田武山", "100" }, { "王三明", "68" } };
            int sum2 = 0, avg5 = 0;
            for (int i = 0; i < 8; i++)
            {
                sum2 += int.Parse(info2[i, 1]);//字符串转整型
            }
            avg5 = sum2 / 8;

            Console.WriteLine("平均分是" + avg5 + "，高于平均分的有：");
            for (int i = 0; i < 8; i++)
            {
                if (int.Parse(info2[i, 1]) > avg5)
                    Console.Write(info2[i, 0] + " ");
            }

            Console.WriteLine();

            // 取出最大值
            int[] ss = new int[] { 23, 45, 77, 80, 100 };
            int Max = 0;  // 定义最大值
            int id = 0;  // 记录索引
            Max = ss[0];   // 初始化
            for(int i = 0; i < ss.Length; i++)
            {
                if (ss[i] > Max) {
                    Max = ss[i];
                    id = i;  
                }
                   
            }
            Console.WriteLine("Max = " + Max + "索引 = " + id);


            // 控制台的输入拖动选中要注释的代码 1、注释行 2、注释多行 在主 页面上
            // 选定要处理的行,按 Ctrl+K,Ctrl + C注释选中的行。 按 Ctrl+K,Ctrl + U取消注释选中的行。
            //string nameA;
            //console.write("请输入你的名字:");
            //namea = console.readline();  // 接收用户输入
            //console.writeline("你好，{0}!", namea);

            // 计算平均值最高分-控制台输入
            string[] names = new string[2];
            int[] scores = new int[2];

            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine("请输入第" + (i+ 1) + "位同学的名字：");
                names[i] = Console.ReadLine();
                Console.WriteLine("请输入第"+ (i + 1) + "位同学的分数：");
                scores[i] = int.Parse(Console.ReadLine());
            }

            // 计算总分，平均分
            int sumScores = 0, avg;
            for(int j = 0; j < names.Length; j++)
            {
                // F9： 设置断点，取消断点   单步执行：F10
                sumScores += scores[j];              
            }
            avg = sumScores / names.Length;
            // Console.WriteLine("总分是："+ sumScores + "平均分是：" + avg);
             Console.WriteLine("总分：{0},平均分是：{1}" , sumScores, avg); // 这里的"," --- 不能写为"+"。否则会报索引问题！

        }
    }
}
