//***************************************************************************************************************************************************
//
// File Name: CalculatorWindows.cs
//
// Description:
//  TODO: Add file description.
//
// Change History:
//  Author               Date           Description
//  Matthew D. Yorke     MM/DD/YYYY     TODO: Add Description.
//
//***************************************************************************************************************************************************

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
      //*********************************************************************************************************************************************
      //
      // Method Name: CalculatorWindow
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  N/A
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      public CalculatorWindow()
      {
         // Initialize member variables.
         mInputValueOne = 0.0F;
         mInputValueTwo = 0.0F;
         mOutputValue = 0.0F;
         mCurrentInputStep = InputStep.VALUE_ONE;
         mCurrentOperation = Operation.NONE;
         mClearTextBox = false;
         mEqualsButtonPressed = false;
         mOperationButtonPressed = false;

         // Call to initialize the components (buttons and text box) of the window
         InitializeComponent();

         // Start the text box to be the default output value.
         this.textBox.Text = mOutputValue.ToString();
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueOneButtonsClick
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theSender - TODO: Add description.
      //  theEvent - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueOneButtonsClick(object theSender, EventArgs theEvent)
      {
         if (mEqualsButtonPressed == true)
         {
            this.textBox.Text = "";
            mEqualsButtonPressed = false;
         }

         AppendValue("1");
         mOperationButtonPressed = false;
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueTwoButtonClick
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theSender - TODO: Add description.
      //  theEvent - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueTwoButtonClick(object theSender, EventArgs theEvent)
      {
         if (mEqualsButtonPressed == true)
         {
            this.textBox.Text = "";
            mEqualsButtonPressed = false;
         }

         AppendValue("2");
         mOperationButtonPressed = false;
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueThreeButtonClick
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theSender - TODO: Add description.
      //  theEvent - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueThreeButtonClick(object theSender, EventArgs theEvent)
      {
         if (mEqualsButtonPressed == true)
         {
            this.textBox.Text = "";
            mEqualsButtonPressed = false;
         }

         AppendValue("3");
         mOperationButtonPressed = false;
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueFourButtonClick
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theSender - TODO: Add description.
      //  theEvent - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueFourButtonClick(object theSender, EventArgs theEvent)
      {
         if (mEqualsButtonPressed == true)
         {
            this.textBox.Text = "";
            mEqualsButtonPressed = false;
         }

         AppendValue("4");
         mOperationButtonPressed = false;
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueFiveButtonClick
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theSender - TODO: Add description.
      //  theEvent - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueFiveButtonClick(object theSender, EventArgs theEvent)
      {
         if (mEqualsButtonPressed == true)
         {
            this.textBox.Text = "";
            mEqualsButtonPressed = false;
         }

         AppendValue("5");
         mOperationButtonPressed = false;
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueSixButtonClick
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theSender - TODO: Add description.
      //  theEvent - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueSixButtonClick(object theSender, EventArgs theEvent)
      {
         if (mEqualsButtonPressed == true)
         {
            this.textBox.Text = "";
            mEqualsButtonPressed = false;
         }

         AppendValue("6");
         mOperationButtonPressed = false;
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueSevenButtonClick
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theSender - TODO: Add description.
      //  theEvent - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueSevenButtonClick(object theSender, EventArgs theEvent)
      {
         if (mEqualsButtonPressed == true)
         {
            this.textBox.Text = "";
            mEqualsButtonPressed = false;
         }

         AppendValue("7");
         mOperationButtonPressed = false;
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueEightButtonClick
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theSender - TODO: Add description.
      //  theEvent - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueEightButtonClick(object theSender, EventArgs theEvent)
      {
         if (mEqualsButtonPressed == true)
         {
            this.textBox.Text = "";
            mEqualsButtonPressed = false;
         }

         AppendValue("8");
         mOperationButtonPressed = false;
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueNineButtonClick
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theSender - TODO: Add description.
      //  theEvent - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueNineButtonClick(object theSender, EventArgs theEvent)
      {
         if (mEqualsButtonPressed == true)
         {
            this.textBox.Text = "";
            mEqualsButtonPressed = false;
         }

         AppendValue("9");
         mOperationButtonPressed = false;
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueZeroButtonClick
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theSender - TODO: Add description.
      //  theEvent - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueZeroButtonClick(object theSender, EventArgs theEvent)
      {
         if (mEqualsButtonPressed == true)
         {
            this.textBox.Text = "";
            mEqualsButtonPressed = false;
         }

         AppendValue("0");
         mOperationButtonPressed = false;
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: DecimalButtonClick
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theSender - TODO: Add description.
      //  theEvent - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void DecimalButtonClick(object theSender, EventArgs theEvent)
      {
         if (mEqualsButtonPressed == true)
         {
            this.textBox.Text = "0.";
            mEqualsButtonPressed = false;
         }

         if(this.textBox.Text.Contains(".") == false)
         {
            this.textBox.Text = "0.";
         }

         mOperationButtonPressed = false;
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: AdditionButtonClick
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theSender - TODO: Add description.
      //  theEvent - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void AdditionButtonClick(object theSender, EventArgs theEvent)
      {
         ProcessOpertionButtonPressed(Operation.ADDITION);
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: SubtractionButtonClick
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theSender - TODO: Add description.
      //  theEvent - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void SubtractionButtonClick(object theSender, EventArgs theEvent)
      {
         ProcessOpertionButtonPressed(Operation.SUBTRACTION);
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: MultiplicationButtonClick
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theSender - TODO: Add description.
      //  theEvent - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void MultiplicationButtonClick(object theSender, EventArgs theEvent)
      {
         ProcessOpertionButtonPressed(Operation.MULTIPLICATION);
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: DivisionButtonClick
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theSender - TODO: Add description.
      //  theEvent - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void DivisionButtonClick(object theSender, EventArgs theEvent)
      {
         ProcessOpertionButtonPressed(Operation.DIVISION);
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ClearEntryButtonClick
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theSender - TODO: Add description.
      //  theEvent - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ClearEntryButtonClick(object theSender, EventArgs theEvent)
      {
         this.textBox.Text = "0";
         mOperationButtonPressed = false;
         mEqualsButtonPressed = false;
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ClearButtonClick
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theSender - TODO: Add description.
      //  theEvent - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ClearButtonClick(object theSender, EventArgs theEvent)
      {
         mCurrentInputStep = InputStep.VALUE_ONE;
         mCurrentOperation = Operation.NONE;
         mInputValueOne = 0.0F;
         mInputValueTwo = 0.0F;
         mOutputValue = 0.0F;
         this.textBox.Text = "0";
         mOperationButtonPressed = false;
         mEqualsButtonPressed = false;
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: EqualsButtonClick
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theSender - TODO: Add description.
      //  theEvent - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void EqualsButtonClick(object theSender, EventArgs theEvent)
      {
         if (mEqualsButtonPressed == false)
         {
            CheckStep();

            mInputValueOne = mOutputValue;
            mInputValueTwo = 0;

            mEqualsButtonPressed = true;
            mOperationButtonPressed = false;
         }
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: AppendValue
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theValue - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
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

      //*********************************************************************************************************************************************
      //
      // Method Name: ProcessOpertionButtonPressed
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  theOperation - TODO: Add description.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ProcessOpertionButtonPressed(Operation theOperation)
      {
            if (mOperationButtonPressed == false)
         {
            mClearTextBox = true;

            CheckStep();

            mCurrentOperation = theOperation;
            mEqualsButtonPressed = false;
            mOperationButtonPressed = true;
         }
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: CheckStep
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  N/A
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
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

               if (mEqualsButtonPressed == false)
               {
                  Compute();
               }

               break;
            }
            default:
            {
               break;
            }
         }
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: Compute
      //
      // Description:
      //  TODO: Add description.
      //
      // Arguments:
      //  N/A
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
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
         mInputValueOne = mOutputValue;

         mCurrentOperation = Operation.NONE;
      }

      private float mInputValueOne;

      private float mInputValueTwo;

      private float mOutputValue;

      enum InputStep {VALUE_ONE, VALUE_TWO};

      private InputStep mCurrentInputStep;

      enum Operation {ADDITION, SUBTRACTION, MULTIPLICATION, DIVISION, NONE};

      private Operation mCurrentOperation;

      private bool mClearTextBox;

      private bool mEqualsButtonPressed;

      private bool mOperationButtonPressed;
   }
}
