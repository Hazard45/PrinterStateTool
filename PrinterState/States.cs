using System.Collections.Generic;

namespace PrinterState
{
    /// <summary>
    /// Status information for a printer that is different from information specified in the Availability property.
    /// </summary>
    public static class ExtendedPrinterStatus
    {
        private static Dictionary<int, string> states = new Dictionary<int, string>
        {
            { -1, "Undefined" },
            { 0, "Other" },
            { 2, "Unknown" },
            { 3, "Idle" },
            { 4, "Printing" },
            { 5, "Warming Up" },
            { 6, "Stopped Printing" },
            { 7, "Offline" },
            { 8, "Paused" },
            { 9, "Error" },
            { 10, "Busy" },
            { 11, "Not Available" },
            { 12, "Waiting" },
            { 13, "Processing" },
            { 14, "Initialization" },
            { 15, "Power Save" },
            { 16, "Pending Deletion" },
            { 17, "I/O Active" },
            { 18, "Manual Feed" }
        };

        public static string Get(string codeString)
        {
            var code = -1;
            int.TryParse(codeString, out code);
            return states[code];
        }
    }

    /// <summary>
    /// One of the possible states relating to this printer. This property is obsolete. In place of this property, use PrinterStatus.
    /// </summary>
    public static class PrinterState
    {
        private static Dictionary<int, string> states = new Dictionary<int, string>
        {
            { -1, "Undefined" },
            { 0, "Idle" },
            { 2, "Paused" },
            { 3, "Error" },
            { 4, "Pending Deletion" },
            { 5, "Paper Jam" },
            { 6, "Paper Out" },
            { 7, "Manual Feed" },
            { 8, "Paper Problem" },
            { 9, "Offline" },
            { 10, "I/O Active" },
            { 11, "Busy" },
            { 12, "Printing" },
            { 13, "Output Bin Full" },
            { 14, "Not Available" },
            { 15, "Waiting" },
            { 16, "Processing" },
            { 17, "Initialization" },
            { 18, "Warming Up" },
            { 19, "Toner Low" },
            { 20, "No Toner" },
            { 21, "Page Punt" },
            { 22, "User Intervention Required" },
            { 23, "Out of Memory" },
            { 24, "Door Open" },
            { 25, "Server Unknown" },
            { 26, "Power Save" }
        };

        public static string Get(string codeString)
        {
            var code = -1;
            int.TryParse(codeString, out code);
            return states[code];
        }
    }
}