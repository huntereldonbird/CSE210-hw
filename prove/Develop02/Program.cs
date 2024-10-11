using System;
using System.Collections;
using System.Diagnostics;
using System.IO.Compression;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Transactions;

 public class Program
{
    static void Main(){
        RunningProcess runningProcess = new RunningProcess();
        Journal Throwaway = new Journal();
        runningProcess.RunningProgram(Throwaway);
    }

}