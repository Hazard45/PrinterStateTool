using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Management;
using System.Printing;

namespace PrinterState
{
    public class PrinterInfo
    {
        /// <summary>
        /// Printer state
        /// </summary>
        public static bool IsOk { get; private set; }

        private  string printer { get; set; }

        public PrinterInfo(string printerName)
        {
            printer = printerName;
        }

        /// <summary>
        /// Returns all installed printers names
        /// </summary>
        /// <returns>Array of printers names</returns>
        public static string[] GetAllPrinters()
        {
            var printers = PrinterSettings.InstalledPrinters;
            var result = new string[printers.Count];
            printers.CopyTo(result, 0);
            return result;
        }

        /// <summary>
        /// Returns current printer queue info
        /// </summary>
        /// <returns>Current printer queue info</returns>
        public string GetQueueInfo()
        {
            try
            {
                var server = new LocalPrintServer();
                var queue = server.GetPrintQueue(printer);

                IsOk = !queue.HasPaperProblem && queue.HasToner && !queue.IsBusy && !queue.IsInError && !queue.IsNotAvailable && !queue.IsOffline && !queue.IsOutOfMemory &&
                    !queue.IsOutOfPaper && !queue.IsOutputBinFull && !queue.IsPaperJammed;

                return
                    "Full Name: " + queue.FullName + Environment.NewLine +
                    "Has Paper Problem: " + queue.HasPaperProblem + Environment.NewLine +
                    "Has Toner: " + queue.HasToner + Environment.NewLine +
                    "Is Busy: " + queue.IsBusy + Environment.NewLine +
                    "Is Hidden: " + queue.IsHidden + Environment.NewLine +
                    "Is In Error: " + queue.IsInError + Environment.NewLine +
                    "Is Initializing: " + queue.IsInitializing + Environment.NewLine +
                    "Is Not Available: " + queue.IsNotAvailable + Environment.NewLine +
                    "Is Offline: " + queue.IsOffline + Environment.NewLine +
                    "Is Out Of Memory: " + queue.IsOutOfMemory + Environment.NewLine +
                    "Is Out Of Paper: " + queue.IsOutOfPaper + Environment.NewLine +
                    "Is Output Bin Full: " + queue.IsOutputBinFull + Environment.NewLine +
                    "Is Paper Jammed: " + queue.IsPaperJammed + Environment.NewLine +
                    "Is Paused: " + queue.IsPaused + Environment.NewLine +
                    "Is Pending Deletion: " + queue.IsPendingDeletion + Environment.NewLine +
                    "Is Printing: " + queue.IsPrinting + Environment.NewLine +
                    "Is Processing: " + queue.IsProcessing + Environment.NewLine +
                    "Is Published: " + queue.IsPublished + Environment.NewLine +
                    "Is Queued: " + queue.IsQueued + Environment.NewLine +
                    "Is Server Unknown: " + queue.IsServerUnknown + Environment.NewLine +
                    "Is Shared: " + queue.IsShared + Environment.NewLine +
                    "Is Waiting: " + queue.IsWaiting + Environment.NewLine +
                    "Need User Intervention: " + queue.NeedUserIntervention + Environment.NewLine +
                    "Number Of Jobs: " + queue.NumberOfJobs + Environment.NewLine +
                    "Page Punt: " + queue.PagePunt + Environment.NewLine +
                    "Printing Is Cancelled: " + queue.PrintingIsCancelled + Environment.NewLine +
                    "Queue Status: " + queue.QueueStatus + Environment.NewLine +
                    "Share Name: " + queue.ShareName + Environment.NewLine;
            }
            catch (Exception ex)
            {
                IsOk = false;
                throw new Exception("This printer queue is unavailable.", ex);
            }
        }

        /// <summary>
        /// Returns current printer properties info
        /// </summary>
        /// <returns>Current printer properties info</returns>
        public string GetProperties()
        {
            try
            {
                var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Printer WHERE Name = '" + printer + "'");
                var props = searcher.Get();
                if (props.Count == 1)
                {
                    var prop = props.OfType<ManagementObject>().FirstOrDefault();
                    var extendedPrinterStatus = prop["ExtendedPrinterStatus"] != null ? ExtendedPrinterStatus.Get(prop["ExtendedPrinterStatus"].ToString()) : "Undefined";
                    var printerState = prop["PrinterState"] != null ? PrinterState.Get(prop["PrinterState"].ToString()) : "Undefined";

                    return
                        "Name: " + prop["Name"] + Environment.NewLine +
                        "Caption: " + prop["Caption"] + Environment.NewLine +
                        "Extended Printer Status: " + extendedPrinterStatus + Environment.NewLine +
                        "Printer State: " + printerState + Environment.NewLine;
                }
                else
                {
                    throw new Exception("Not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("This printer properties are unavailable.", ex);
            }
        }

        /// <summary>
        /// Returns all printers queues info
        /// </summary>
        /// <returns>List of all printers queues info</returns>
        public static List<PrintQueue> GetAllQueues()
        {
            var server = new LocalPrintServer();
            return server.GetPrintQueues().ToList();
        }
    }
}