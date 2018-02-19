using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         // Initialize member variables.
         mInputValue = 0.0F;
         mOutputValue = 0.0F;

         // Call to initialize the components (buttons and text box) of the window
         InitializeComponent();

         // Start the text box to be the default output value.
         this.textBox.Text = mOutputValue.ToString();
      }

      private void ValueOneButtonsClick(object theSender, EventArgs theEvent)
      {
         AppendValue("1");
      }

      private void ValueTwoButtonClick(object theSender, EventArgs theEvent)
      {
         AppendValue("2");
      }

      private void ValueThreeButtonClick(object theSender, EventArgs theEvent)
      {
         AppendValue("3");
      }

      private void ValueFourButtonClick(object theSender, EventArgs theEvent)
      {
         AppendValue("4");
      }

      private void ValueFiveButtonClick(object theSender, EventArgs theEvent)
      {
         AppendValue("5");
      }

      private void ValueSixButtonClick(object theSender, EventArgs theEvent)
      {
         AppendValue("6");
      }

      private void ValueSevenButtonClick(object theSender, EventArgs theEvent)
      {
         AppendValue("7");
      }

      private void ValueEightButtonClick(object theSender, EventArgs theEvent)
      {
         AppendValue("8");
      }

      private void ValueNineButtonClick(object theSender, EventArgs theEvent)
      {
         AppendValue("9");
      }

      private void ValueZeroButtonClick(object theSender, EventArgs theEvent)
      {
         AppendValue("0");
      }

      private void DecimalButtonClick(object theSender, EventArgs theEvent)
      {
         if(this.textBox.Text.Contains(".") == false)
         {
            AppendValue(".");
         }
      }

      private void AdditionButtonClick(object theSender, EventArgs theEvent)
      {

      }

      private void SubtractionButtonClick(object theSender, EventArgs theEvent)
      {

      }

      private void MultiplicationButtonClick(object theSender, EventArgs theEvent)
      {

      }

      private void DivisionButtonClick(object theSender, EventArgs theEvent)
      {

      }

      private void ClearEntryButtonClick(object theSender, EventArgs theEvent)
      {

      }

      private void ClearButtonClick(object theSender, EventArgs theEvent)
      {
         this.textBox.Text = "0";
      }

      private void EqualsButtonClick(object theSender, EventArgs theEvent)
      {
         this.textBox.Text = mOutputValue.ToString();
      }

      private void AppendValue(string theValue)
      {
         if(this.textBox.Text == "0" && theValue != ".")
         {
            this.textBox.Text = "";
         }

         this.textBox.Text += theValue;
      }

      private float mInputValue;

      private float mOutputValue;
   }
}
