﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YassakawaInterface;

namespace YassakawaInterfaceTests
{
    class Program
    {
        static void Main(string[] args)
        {
            YassakawaController yassakawaController = new YassakawaController("10.0.0.2", "");

            Servo_ON_Test(yassakawaController);

            Moving_Linear_X_Test(yassakawaController);

            Thread.Sleep(2000);

            Servo_OFF_Test(yassakawaController);

            Disconnect_Test(yassakawaController);

            //Console.ReadLine();
        }

        public static void Connect_Test(YassakawaController yassakawaController)
        {
            yassakawaController.Connect();
        }

        public static void Disconnect_Test(YassakawaController yassakawaController)
        {
            yassakawaController.Disconnect();
        }

        public static void Servo_ON_Test(YassakawaController yassakawaController)
        {
            yassakawaController.ServoOn();
        }

        public static void Servo_OFF_Test(YassakawaController yassakawaController)
        {
            yassakawaController.ServoOff();
        }

        public static void Moving_Linear_X_Test(YassakawaController yassakawaController)
        {
            short result = yassakawaController.MoveLinearIncrementX("V" , 10 , "ROBOT" , 0 , 0 , 5); ;

            Console.WriteLine($"{result}");
        }
        public static void Moving_Linear_Y_Test(YassakawaController yassakawaController)
        {
            short result = yassakawaController.MoveLinearIncrementY("V", 10, "ROBOT", 0, 0, 5); ;

            Console.WriteLine($"{result}");
        }
        public static void Moving_Linear_Z_Test(YassakawaController yassakawaController)
        {
            short result = yassakawaController.MoveLinearIncrementZ("V", 10, "ROBOT", 0, 0, 5); ;

            Console.WriteLine($"{result}");
        }
        public static void Moving_Linear_RX_Test(YassakawaController yassakawaController)
        {
            short result = yassakawaController.MoveLinearIncrementRX("V", 10, "ROBOT", 0, 0, 5); ;

            Console.WriteLine($"{result}");
        }
        public static void Moving_Linear_RY_Test(YassakawaController yassakawaController)
        {
            short result = yassakawaController.MoveLinearIncrementRY("V", 10, "ROBOT", 0, 0, 5); ;

            Console.WriteLine($"{result}");
        }
        public static void Moving_Linear_RZ_Test(YassakawaController yassakawaController)
        {
            short result = yassakawaController.MoveLinearIncrementRZ("V", 10, "ROBOT", 0, 0, 5); ;

            Console.WriteLine($"{result}");
        }
    }
}
