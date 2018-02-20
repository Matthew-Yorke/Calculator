//***************************************************************************************************************************************************
//
// File Name: Program.cs
//
// Description:
//  Automatically generated code that kicks of the program and indicated the calculator window to be created.
//
// Change History:
//  Author               Date           Description
//  Matthew D. Yorke     02/20/2018     TODO: Add Description.
//
//***************************************************************************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new CalculatorWindow());
      }
   }
}
