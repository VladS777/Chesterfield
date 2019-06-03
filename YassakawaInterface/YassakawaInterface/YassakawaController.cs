﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotocomdotNetWrapper;

namespace YassakawaInterface
{
    public class YassakawaController
    {
        public CYasnac m_cYasnac { get; set; }

        /// <summary>
        /// Default construvtor for creating a Yassakawa Robot object.
        /// </summary>
        /// <param name="IPAddress">The robot IP address.</param>
        /// <param name="path">The path to the robot directory.</param>
        public YassakawaController(string IPAddress , string path)
        {
            m_cYasnac = new CYasnac(IPAddress , path);
        }

        /// <summary>
        /// Setting the robot servo on.
        /// </summary>
        public void ServoOn()
        {
            m_cYasnac.SetServoOn();
        }

        /// <summary>
        /// Setting the robot servo off.
        /// </summary>
        public void ServoOff()
        {
            m_cYasnac.SetServoOff();
        }
    }
}
