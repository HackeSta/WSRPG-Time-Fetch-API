using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WSTimeFetch
{
    public class TimeFetch
    {
        const int PROCESS_WM_READ = 0x0010;

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        private static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        private static Process process;
        private static Process[] _process;
        private static IntPtr processHandle;
        
        private static bool Init() 
        {
            try
            {
                _process = Process.GetProcessesByName("gta_sa");
                if (_process.Length == 0)
                {
                    return false;
                }
                else
                {
                    process = _process[0];
                    processHandle = OpenProcess(PROCESS_WM_READ, false, process.Id);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static int getHour() //Returns the in-game hour
        {
            if (Init())
            {
                int bytesReadHours = 0;
                byte[] bufferHours = new byte[1];

                ReadProcessMemory((int)processHandle, 0x00B70153, bufferHours, bufferHours.Length, ref bytesReadHours);

                return (int)bufferHours[0];
            }
            else
            {
                return 0;
            }
        }

        public static int getMinute() //Returns the in-game minute
        {
            if (Init())
            {
                int bytesReadMinutes = 0;
                byte[] bufferMinutes = new byte[1];

                ReadProcessMemory((int)processHandle, 0x00B70152, bufferMinutes, bufferMinutes.Length, ref bytesReadMinutes);

                return (int)bufferMinutes[0];
            }
            else
            {
                return 0;
            }
        }

        

    }
}
