using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  public  class method
    {
      /// <summary>
      /// 将钱换算为酒瓶数并计算
      /// </summary>
      /// <param name="n">钱的个数</param>
      /// <returns></returns>
        public static int drinkMethod(int n) //n是钱的个数
        {
            int num = n/2;   //num是最终瓶子个数
            return method(num);
        }
      /// <summary>
      /// 计算空瓶子和瓶盖都换酒是酒的个数
      /// </summary>
        /// <param name="n">总酒瓶数</param>
        /// <param name="m">已用于换新酒的瓶子数</param>
        /// <param name="l">已用于换新酒的瓶盖数</param>
      /// <returns>最终酒的个数</returns>
        private static int method(int n, int m = 0, int l = 0) //n是总酒瓶数，m是已用于换新酒的瓶子数，l是已用于换新酒的盖子数
        {
            int i1 = (n - m) / 2;
            int j1 = (n - m) % 2;
            int num1 = m + i1 * 2;            //用过的空瓶数
            int i2 = (n - l) / 4;
            int j2 = (n - l) % 4;
            int num2 = l + i2 * 4;            //用过的空瓶数用过的瓶盖数
            int num = n + i1 + i2;            //总瓶数
            if (i1 == 0 && i2 == 0)
            {
                num = n;
                return num;
            }
            else
            {
                return method(num, num1, num2);  //i1+i2+j1由于能被4整除的肯定内被2整除，且为了防止重复添加所以只需要+j1不需要j2

            }
        }
      /// <summary>
      /// 只计算空瓶瓶子换酒时酒的个数
      /// </summary>
      /// <param name="n">酒瓶子的个数</param>
      /// <param name="m">已经用过瓶子个数</param>
        /// <returns>最终酒的个数</returns>
        private static int method1(int n, int m = 0) //计算空瓶子可以换的酒瓶
        {
            int i = n / 2;
            int j = n % 2;
            int num =m + n - j;
            if (i == 0)
            {
                num = num + j;
                return num;
            }else
            {
                return method1(i + j, num);
              
            }
        }
      /// <summary>
      /// 只计算瓶盖换酒时酒的个数 
      /// </summary>
        /// <param name="n">酒瓶子的个数</param>
        /// <param name="m">已经用过瓶盖个数</param>
        /// <returns>最终酒的个数</returns>
        private static int method2(int n, int m = 0) //计算瓶盖可以换的酒瓶 n是初始酒瓶数，m是以用于换新酒的盖子子数
        {
            int i = n / 4;
            int j = n % 4;
            int num = m + n - j;
            if (i == 0)
            {
                num = num + j;
                return num;
            }
            else
            {
                return method2(i + j, num);

            }
        }
       
    }   

}
