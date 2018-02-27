//***************************************************************************************************************************************************
//
// File Name: CalculatorWindows.cs
//
// Description:
//  This class contains the functionality of the calculator window. Callbacks are provided for each individual button.
//
// Change History:
//  Author               Date           Description
//  Matthew D. Yorke     02/20/2018     Initial release.
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
      //  The constructor for the calculator window class. Initialization is called here to create the window components and set the member variables
      //  to their default values.
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
         // Call to initialize the components (buttons and text box) of the window
         InitializeComponent();

         // Call to reset the member variables to the default state and clear the text box back to zero.
         ResetCalculator();
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueOneButtonsClick
      //
      // Description:
      //  Callback for the one button that appends the number one to the end of the string in the calculators text box.
      //
      // Arguments:
      //  theSender - Contains a reference to the control/object that raised the event. In this case it will be the one button on the calculator
      //              window. This is not used in this method, but is needed to match the callback parameters.
      //  theEvent  - Contains the events data. This is not used in this method, but is needed to match the callback parameters.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueOneButtonsClick(object theSender, EventArgs theEvent)
      {
         AppendValue("1");
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueTwoButtonClick
      //
      // Description:
      //  Callback for the two button that appends the number two to the end of the string in the calculators text box.
      //
      // Arguments:
      //  theSender - Contains a reference to the control/object that raised the event. In this case it will be the two button on the calculator
      //              window. This is not used in this method, but is needed to match the callback parameters.
      //  theEvent  - Contains the events data. This is not used in this method, but is needed to match the callback parameters.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueTwoButtonClick(object theSender, EventArgs theEvent)
      {
         AppendValue("2");
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueThreeButtonClick
      //
      // Description:
      //  Callback for the three button that appends the number three to the end of the string in the calculators text box.
      //
      // Arguments:
      //  theSender - Contains a reference to the control/object that raised the event. In this case it will be the three button on the calculator
      //              window. This is not used in this method, but is needed to match the callback parameters.
      //  theEvent  - Contains the events data. This is not used in this method, but is needed to match the callback parameters.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueThreeButtonClick(object theSender, EventArgs theEvent)
      {
         AppendValue("3");
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueFourButtonClick
      //
      // Description:
      //  Callback for the four button that appends the number four to the end of the string in the calculators text box.
      //
      // Arguments:
      //  theSender - Contains a reference to the control/object that raised the event. In this case it will be the four button on the calculator
      //              window. This is not used in this method, but is needed to match the callback parameters.
      //  theEvent  - Contains the events data. This is not used in this method, but is needed to match the callback parameters.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueFourButtonClick(object theSender, EventArgs theEvent)
      {
         AppendValue("4");
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueFiveButtonClick
      //
      // Description:
      //  Callback for the five button that appends the number five to the end of the string in the calculators text box.
      //
      // Arguments:
      //  theSender - Contains a reference to the control/object that raised the event. In this case it will be the five button on the calculator
      //              window. This is not used in this method, but is needed to match the callback parameters.
      //  theEvent  - Contains the events data. This is not used in this method, but is needed to match the callback parameters.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueFiveButtonClick(object theSender, EventArgs theEvent)
      {
         AppendValue("5");
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueSixButtonClick
      //
      // Description:
      //  Callback for the six button that appends the number six to the end of the string in the calculators text box.
      //
      // Arguments:
      //  theSender - Contains a reference to the control/object that raised the event. In this case it will be the six button on the calculator
      //              window. This is not used in this method, but is needed to match the callback parameters.
      //  theEvent  - Contains the events data. This is not used in this method, but is needed to match the callback parameters.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueSixButtonClick(object theSender, EventArgs theEvent)
      {
         AppendValue("6");
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueSevenButtonClick
      //
      // Description:
      //  Callback for the seven button that appends the number seven to the end of the string in the calculators text box.
      //
      // Arguments:
      //  theSender - Contains a reference to the control/object that raised the event. In this case it will be the seven button on the calculator
      //              window. This is not used in this method, but is needed to match the callback parameters.
      //  theEvent  - Contains the events data. This is not used in this method, but is needed to match the callback parameters.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueSevenButtonClick(object theSender, EventArgs theEvent)
      {
         AppendValue("7");
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueEightButtonClick
      //
      // Description:
      //  Callback for the eight button that appends the number eight to the end of the string in the calculators text box.
      //
      // Arguments:
      //  theSender - Contains a reference to the control/object that raised the event. In this case it will be the eight button on the calculator
      //              window. This is not used in this method, but is needed to match the callback parameters.
      //  theEvent  - Contains the events data. This is not used in this method, but is needed to match the callback parameters.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueEightButtonClick(object theSender, EventArgs theEvent)
      {
         AppendValue("8");
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueNineButtonClick
      //
      // Description:
      //  Callback for the nine button that appends the number nine to the end of the string in the calculators text box.
      //
      // Arguments:
      //  theSender - Contains a reference to the control/object that raised the event. In this case it will be the nine button on the calculator
      //              window. This is not used in this method, but is needed to match the callback parameters.
      //  theEvent  - Contains the events data. This is not used in this method, but is needed to match the callback parameters.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueNineButtonClick(object theSender, EventArgs theEvent)
      {
         AppendValue("9");
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ValueZeroButtonClick
      //
      // Description:
      //  Callback for the zero button that appends the number zero to the end of the string in the calculators text box.
      //
      // Arguments:
      //  theSender - Contains a reference to the control/object that raised the event. In this case it will be the zero button on the calculator
      //              window. This is not used in this method, but is needed to match the callback parameters.
      //  theEvent  - Contains the events data. This is not used in this method, but is needed to match the callback parameters.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ValueZeroButtonClick(object theSender, EventArgs theEvent)
      {
         AppendValue("0");
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: DecimalButtonClick
      //
      // Description:
      //  Callback for the decimal button that appends the decimal to the end of the string in the calculators text box. If there is already a
      //  decimal in the string another decimal will NOT be placed.
      //
      // Arguments:
      //  theSender - Contains a reference to the control/object that raised the event. In this case it will be the decimal button on the calculator
      //              window. This is not used in this method, but is needed to match the callback parameters.
      //  theEvent  - Contains the events data. This is not used in this method, but is needed to match the callback parameters.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void DecimalButtonClick(object theSender, EventArgs theEvent)
      {
         // Check if either the text box does NOT currently contain a decimal OR if the equals button was pressed last.
         if(this.TextBox.Text.Contains(".") == false)
         {
            this.TextBox.Text += ".";
         }
         if((mEqualsButtonPressed == true) ||
            (mOperationButtonPressed == true))
         {
            this.TextBox.Text = "0.";
         }

         // Update the equals and operation trackers to indicate neither button was last pressed.
         // Also update the clear text box tracker as the text box no longer should be cleared anymore due to a decimal being placed.
         mEqualsButtonPressed = false;
         mOperationButtonPressed = false;
         mClearTextBox = false;
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: AdditionButtonClick
      //
      // Description:
      //  Callback for the addition button that calls to process that the addition button has been pressed.
      //
      // Arguments:
      //  theSender - Contains a reference to the control/object that raised the event. In this case it will be the addition button on the calculator
      //              window. This is not used in this method, but is needed to match the callback parameters.
      //  theEvent  - Contains the events data. This is not used in this method, but is needed to match the callback parameters.
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
      //  Callback for the subtraction button that calls to process that the subtraction button has been pressed.
      //
      // Arguments:
      //  theSender - Contains a reference to the control/object that raised the event. In this case it will be the subtraction button on the
      //              calculator window. This is not used in this method, but is needed to match the callback parameters.
      //  theEvent  - Contains the events data. This is not used in this method, but is needed to match the callback parameters.
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
      //  Callback for the multiplication button that calls to process that the multiplication button has been pressed.
      //
      // Arguments:
      //  theSender - Contains a reference to the control/object that raised the event. In this case it will be the multiplication button on the
      //              calculator window. This is not used in this method, but is needed to match the callback parameters.
      //  theEvent  - Contains the events data. This is not used in this method, but is needed to match the callback parameters.
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
      //  Callback for the division button that calls to process that the division button has been pressed.
      //
      // Arguments:
      //  theSender - Contains a reference to the control/object that raised the event. In this case it will be the division button on the calculator
      //              window. This is not used in this method, but is needed to match the callback parameters.
      //  theEvent  - Contains the events data. This is not used in this method, but is needed to match the callback parameters.
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
      //  Callback for the clear entry button that clears the text box back to the default zero value. Also the tracking variables for if an operation
      //  and equals buttons being pressed are reset to the default false value.
      //
      // Arguments:
      //  theSender - Contains a reference to the control/object that raised the event. In this case it will be the clear entry button on the
      //              calculator window. This is not used in this method, but is needed to match the callback parameters.
      //  theEvent  - Contains the events data. This is not used in this method, but is needed to match the callback parameters.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ClearEntryButtonClick(object theSender, EventArgs theEvent)
      {
         // Reset the text box to its default zero value.
         this.TextBox.Text = "0";

         // Update the equals and operation trackers that neither were the last buttons pressed.
         mOperationButtonPressed = false;
         mEqualsButtonPressed = false;
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ClearButtonClick
      //
      // Description:
      //  Callback for the clear button that resets all member variables to their default values and clears the text box to the default zero value.
      //
      // Arguments:
      //  theSender - Contains a reference to the control/object that raised the event. In this case it will be the clear button on the calculator
      //              window. This is not used in this method, but is needed to match the callback parameters.
      //  theEvent  - Contains the events data. This is not used in this method, but is needed to match the callback parameters.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ClearButtonClick(object theSender, EventArgs theEvent)
      {
         ResetCalculator();
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: EqualsButtonClick
      //
      // Description:
      //  Callback for the equals button that calculates the two values being calculated which the output is displayed in the text box. There is
      //  prevention for the operator pressing equals button multiple times in a row.
      //
      // Arguments:
      //  theSender - Contains a reference to the control/object that raised the event. In this case it will be the equals button on the calculator
      //              window. This is not used in this method, but is needed to match the callback parameters.
      //  theEvent  - Contains the events data. This is not used in this method, but is needed to match the callback parameters.
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void EqualsButtonClick(object theSender, EventArgs theEvent)
      {
         // Check if the equals button was already pressed.
         if (mEqualsButtonPressed == false)
         {
            // Check which step is next (first value being entered or second value being entered).
            CheckStep();

            // Update the first input value to be outcome of the computation.
            mInputValueOne = mOutputValue;
            // Update the second value to a default zero.
            mInputValueTwo = 0;

            // Update the equals and operation trackers indicate the equals button was the last button pressed.
            mEqualsButtonPressed = true;
            mOperationButtonPressed = false;
         }
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ResetCalculator
      //
      // Description:
      //  Reset member variables to their default values and set the text box to its default value of zero.
      //
      // Arguments:
      //  N/A
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ResetCalculator()
      {
         // Set member variables to default values.
         mInputValueOne = 0.0F;
         mInputValueTwo = 0.0F;
         mOutputValue = 0.0F;
         mCurrentInputStep = InputStep.VALUE_ONE;
         mCurrentOperation = Operation.NONE;
         mClearTextBox = false;
         mEqualsButtonPressed = false;
         mOperationButtonPressed = false;

         // Start the text box to be the default output value.
         this.TextBox.Text = "0";
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
         // If the equals was pressed then clear the text box to allow a new string to be started.
         if (mEqualsButtonPressed == true)
         {
            this.TextBox.Text = "";
            ResetCalculator();
         }

         // If the string is currently only "0" and theValue being processed is not a decimal then clear the text box to allow a new string to start.
         if((this.TextBox.Text == "0") ||
            (mClearTextBox == true))
         {
            this.TextBox.Text = "";
            mClearTextBox = false;
         }

         // Append the value to the end of the string in the text box.
         this.TextBox.Text += theValue;

         // Since this is a numerical button then the tracker for if an operation button is pressed is set to false.
         mOperationButtonPressed = false;
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: ProcessOpertionButtonPressed
      //
      // Description:
      //  Called when an operation button is pressed, this helper method processes the calculation between the two user input values. The operation
      //  tracker i updated with the operation type the was pressed. There is a prevention for allowing an operation pressed multiple times in a row.
      //
      // Arguments:
      //  theOperation - The operation that indicates which operation is to be processed (addition, subtraction, multiplication, or division).
      //
      // Return:
      //  N/A
      //
      //*********************************************************************************************************************************************
      private void ProcessOpertionButtonPressed(Operation theOperation)
      {
         // Update the current operation to be the passed in value.
         mCurrentOperation = theOperation;

         // Make sure an operation button hasn't already been pressed.
         if (mOperationButtonPressed == false)
         {
            // Indicate that the next numerical/decimal input will clear the text box as it will be the start of a new string of numbers.
            mClearTextBox = true;

            // Check which step is next (first value being entered or second value being entered).
            CheckStep();

            // Update the equals and operation button trackers to indicate an operation button was the last type of button pressed.
            mEqualsButtonPressed = false;
            mOperationButtonPressed = true;
         }
      }

      //*********************************************************************************************************************************************
      //
      // Method Name: CheckStep
      //
      // Description:
      //  Check to see if this is the first value being put in or the second. Note that after the first value is entered the clear button must be
      //  pressed to allow the operator to input a first number again. Also note that if computation occurs then the first value is updated to be
      //  the same as the output of the computation.
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
         // Determine which input the operator is on.
         switch(mCurrentInputStep)
         {
            // The first value has been entered so store this value and set that the next value will be for step two.
            case InputStep.VALUE_ONE:
            {
               mInputValueOne = float.Parse(this.TextBox.Text, CultureInfo.InvariantCulture.NumberFormat);

               mCurrentInputStep = InputStep.VALUE_TWO;

               break;
            }
            // The second value has been entered so store this value and compute the result between value one and two.
            case InputStep.VALUE_TWO:
            {
               mInputValueTwo = float.Parse(this.TextBox.Text, CultureInfo.InvariantCulture.NumberFormat);

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
      //  Computes the first and second input values to produce an output. The text box is updated with the new value and the first value is also
      //  updated with the same as the new value. The operation tracker is cleared.
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
         // Determine which operation to execute.
         switch(mCurrentOperation)
         {
            // The addition operation stores the sum of the first and second input values.
            case Operation.ADDITION:
            {
               mOutputValue = mInputValueOne + mInputValueTwo;
               break;
            }
            // The subtraction operation stores the difference between the first and second input values.
            case Operation.SUBTRACTION:
            {
               mOutputValue = mInputValueOne - mInputValueTwo;
               break;
            }
            // The multiplication operation stores the product of the first and second input values.
            case Operation.MULTIPLICATION:
            {
               mOutputValue = mInputValueOne * mInputValueTwo;
               break;
            }
            // The addition operation stores the quotient of the first and second input values.
            case Operation.DIVISION:
            {
               mOutputValue = mInputValueOne / mInputValueTwo;
               break;
            }
            // If the operation was not selected or an error has occurred, do nothing.
            case Operation.NONE:
            default:
            {
               break;
            }
         }

         // Update the text box with the new value computed.
         this.TextBox.Text = mOutputValue.ToString();
         // Update the first value to be the new value as the only the second value will be updated until cleared.
         mInputValueOne = mOutputValue;
         // Update the current operation tracker to be cleared.
         mCurrentOperation = Operation.NONE;
      }

      // The first value being stored either by the operator input or as the computational answer as only the second value is updated until cleared.
      private float mInputValueOne;

      // The second value being stored by the operator input.
      private float mInputValueTwo;

      // The output of the computation between the first and second input values.
      private float mOutputValue;

      // The possible input states are either entering the first value by the operator (VALUE_ONE) or the second value (VALUE_TWO),
      enum InputStep {VALUE_ONE, VALUE_TWO};

      // Tracks which input step the program is currently in.
      private InputStep mCurrentInputStep;

      // The possible operations that can be pressed.
      enum Operation {ADDITION, SUBTRACTION, MULTIPLICATION, DIVISION, NONE};

      // Tracks which operation button was pressed last.
      private Operation mCurrentOperation;

      // Tracks to see if the text box should be cleared on the next numerical/decimal input.
      private bool mClearTextBox;

      // Tracks if the equals button was the last button pressed.
      private bool mEqualsButtonPressed;

      // Tracks if an operation (addition, subtraction, multiplication, division) was the last button pressed.
      private bool mOperationButtonPressed;
   }
}
