using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculator
{
   public partial class CalculatorWindow : Form
   {
      public CalculatorWindow()
      {
         // Initialize member variables.
         mInputValueOne = 0.0F;
         mInputValueTwo = 0.0F;
         mOutputValue = 0.0F;
         mCurrentInputStep = InputStep.VALUE_ONE;
         mCurrentOperation = Operation.NONE;
         mClearTextBox = false;

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
         mCurrentOperation = Operation.ADDITION;
         mClearTextBox = true;

         CheckStep();
      }

      private void SubtractionButtonClick(object theSender, EventArgs theEvent)
      {
         mCurrentOperation = Operation.SUBTRACTION;
         mClearTextBox = true;

         CheckStep();
      }

      private void MultiplicationButtonClick(object theSender, EventArgs theEvent)
      {
         mCurrentOperation = Operation.MULTIPLICATION;
         mClearTextBox = true;

         CheckStep();
      }

      private void DivisionButtonClick(object theSender, EventArgs theEvent)
      {
         mCurrentOperation = Operation.DIVISION;
         mClearTextBox = true;

         CheckStep();
      }

      private void ClearEntryButtonClick(object theSender, EventArgs theEvent)
      {
         this.textBox.Text = "0";
      }

      private void ClearButtonClick(object theSender, EventArgs theEvent)
      {
         mCurrentInputStep = InputStep.VALUE_ONE;
         mCurrentOperation = Operation.NONE;
         mInputValueOne = 0.0F;
         mInputValueTwo = 0.0F;
         mOutputValue = 0.0F;
         this.textBox.Text = "0";
      }

      private void EqualsButtonClick(object theSender, EventArgs theEvent)
      {
         CheckStep();

         mCurrentOperation = Operation.NONE;
      }

      private void AppendValue(string theValue)
      {
         if((this.textBox.Text == "0" && theValue != ".") ||
            (mClearTextBox == true))
         {
            this.textBox.Text = "";
            mClearTextBox = false;
         }

         this.textBox.Text += theValue;
      }

      private void CheckStep()
      {
         switch(mCurrentInputStep)
         {
            case InputStep.VALUE_ONE:
            {
               mInputValueOne = float.Parse(this.textBox.Text, CultureInfo.InvariantCulture.NumberFormat);

               mCurrentInputStep = InputStep.VALUE_TWO;

               break;
            }
            case InputStep.VALUE_TWO:
            {
               mInputValueTwo = float.Parse(this.textBox.Text, CultureInfo.InvariantCulture.NumberFormat);

               Compute();

               mInputValueOne = mOutputValue;

               break;
            }
            default:
            {
               break;
            }
         }
      }

      private void Compute()
      {
         switch(mCurrentOperation)
         {
            case Operation.ADDITION:
            {
               mOutputValue = mInputValueOne + mInputValueTwo;
               break;
            }
            case Operation.SUBTRACTION:
            {
               mOutputValue = mInputValueOne - mInputValueTwo;
               break;
            }
            case Operation.MULTIPLICATION:
            {
               mOutputValue = mInputValueOne * mInputValueTwo;
               break;
            }
            case Operation.DIVISION:
            {
               mOutputValue = mInputValueOne / mInputValueTwo;
               break;
            }
            case Operation.NONE:
            default:
            {
               break;
            }
         }

         this.textBox.Text = mOutputValue.ToString();

         mCurrentOperation = Operation.NONE;
      }

      private float mInputValueOne;

      private float mInputValueTwo;

      private float mOutputValue;

      enum InputStep {VALUE_ONE, VALUE_TWO};

      private InputStep mCurrentInputStep;

      enum Operation {ADDITION, SUBTRACTION, MULTIPLICATION, DIVISION, NONE};

      private Operation mCurrentOperation;

      bool mClearTextBox;
   }
}
