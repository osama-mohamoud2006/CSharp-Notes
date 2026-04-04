# Pizza Ordering Application (First Ver)
<img width="1397" height="574" alt="image" src="https://github.com/user-attachments/assets/518cdb3e-69ac-4a3d-a017-0a7cc2bffbf4" />


## Overview
This is a Windows Forms desktop application built using C# and .NET Framework 4.8.1. It provides an interactive, real-time interface for users to build a custom pizza order, dynamically calculating the total price based on size, crust type, and selected toppings. 

## Functional Features
* **Dynamic Price Calculation:** The total price updates in real-time as the user selects or deselects different options.
* **Component Selection:**
  * **Size:** Small, Medium, Large.
  * **Crust Type:** Thin, Thick.
  * **Toppings:** Extra Cheese, Onion, Mushrooms, Olives, Tomatoes, Green Peppers.
  * **Dining Option:** Eat In, Takeout.
* **Live Order Summary:** A dedicated panel visually summaries the user's current choices (Size, Crust, Toppings, Location) before they commit to the order.
* **Order Placement:** Locks in the user's choices and disables form controls to prevent tampering after an order is confirmed.
* **Form Reset:** Clears all fields, resets the price to $0, and unlocks the form for a new customer.

---

## Core Logic & Architecture Deep Dive

The application relies heavily on the WinForms `Control.Tag` property to store strongly typed custom data. This avoids hardcoding prices into `switch` statements and allows the logic to scale easily.

### 1. Data Structure Design
The application uses a private struct `stDataForEachTag` to hold the metadata for each option:

During the `frmMain()` initialization, the application binds an instance of this struct to the `.Tag` property of every relevant `RadioButton` and `CheckBox`. 

### 2. Initialization & Data Binding
When the form loads, two main functions build the pricing definitions:
* **`AssignTagsValuesForRadioButtons()`**: Binds sizes (Small ($10), Medium ($20), Large ($30)) and crust types (Thin ($2), Thick ($5)) to their respective RadioButtons using synchronized arrays.
* **`AssignTagsValuesForCheckBoxes()`**: Uses a 3x2 **2D Grid Array** to elegantly map the names and prices (ranging from $1.40 to $2.70) of toppings to the `CheckBox` controls (e.g., `cbExtraCheese`, `cbOnion`). 

### 3. Dynamic Price Calculation Logic
The application maintains a global `_TotalPrice` variable. The calculation logic differs slightly depending on the control type:

#### Checkboxes (Toppings) Logic
Checkboxes are straightforward because they represent togglable external add-ons. 
* Event: `cb_CheckedChanged`
* **Logic:** When triggered, the sender's `Tag` is cast back to `stDataForEachTag`. If the state is `Checked`, the struct's `price` is added to `_TotalPrice`. If unchecked, it is subtracted. 

#### RadioButtons (Size & Crust) Logic
RadioButtons are mutually exclusive. To handle pricing without recalculating the entire form from scratch, the application uses a "Memoization/Rollback" approach:
* State Tracking: Uses `TheLastRbOfSize` and `TheLastRbOfCurstType` to track the *previously* selected options.
* **Logic:** (e.g., `UpdatePriceForSizesRadioButtons`)
  1. If `TheLastRbOfSize` is not null (meaning the user is changing their mind), the application **subtracts** the price of the old selection from the total.
  2. It then scans the group, finds the newly checked RadioButton, **adds** its price to the total, and updates the `TheLastRbOfSize` variable to the current one. 

### 4. Real-time Summary Updates
Whenever a price-affecting control is clicked, the application also calls specific UI update functions:
* `SetLabelForSizeSummary` / `SetLabelCurstSummary`: Directly reads the `Text` of the selected RadioButton and updates the summary label.
* `SetLabelForSummaryToppining`: Iterates over the array of topping CheckBoxes. Every checked box appends its name and a newline (`\n`) to the toppings summary label.
* `UpdatePriceLabel`: Applies a `Math.Ceiling()` function to the `_TotalPrice` and prevents the value from accidentally dropping below $0.

---

## Complete Workflows

### Ordering Workflow
1. The user interacts with the UI (triggering the calculation events described above).
2. The user clicks **"Order"** (`btnOrder_Click`).
3. A `MessageBox` prompts for confirmation ("Are You Sure?").
4. If the user clicks `OK`, the `DisableGroupsForOrder()` function is called.
5. `DisableGroupsForOrder()` sets `.Enabled = false` on every grouping container (`GroupBox`), locking the UI so no further edits can be made. 
6. A success message is shown, and the Order button disables itself.

### Reset Workflow
1. The user clicks **"Reset"** (`btnRest_Click`).
2. A `MessageBox` warns the user they will lose their current selection.
3. If confirmed, `RestAllControls()` fires.
4. **Cleanup:** 
   * Custom helper methods (`UnCheckAllCheckBoxes`, `UncheckAllRadioBtns`, etc.) iterate through all controls and set `item.Checked = false`.
   * State tracking (`TheLastRbOfSize`, etc.) are wiped to `null`.
   * `_TotalPrice` drops to 0.
   * Summary labels are wiped blank.
5. All `GroupBox` controls are re-enabled, readying the interface for the next transaction.

-------------------------------------------------------------------------------------------------------------------------------------------------
# Refactored Version: 
<img width="1142" height="602" alt="image" src="https://github.com/user-attachments/assets/62510ab1-14c5-45da-ac2c-9ef1dc3dbde1" />

## Pizza Order Management System

## Overview
The Pizza Order Management System is a Windows Forms application built using C# 7.3 and .NET Framework 4.8.1. It allows users to customize their pizza orders by selecting size, crust type, toppings, and dining preferences. The application dynamically calculates the total price based on the selected options and provides a real-time order summary.

## Features
- **Real-time Price Calculation**: Dynamically updates the total price as the user selects or deselects options.
- **Dynamic Order Summary**: Displays a live summary of the selected size, crust, toppings, and dining location.
- **Order Confirmation**: Prompts the user with a confirmation dialog before finalizing the order.
- **State Management**: Locks the form selections once an order is placed to prevent unintended modifications.
- **Reset Functionality**: Allows resetting the form to its default state for a new order.

## Technical Details

### Price Calculation System
The system relies on the `Tag` property of the RadioButtons and CheckBoxes to store the price of each item. 
- `CalcPriceOfSize()`: Checks which size RadioButton is selected and retrieves its price.
- `CalcPriceOfCurstType()`: Checks which crust RadioButton is selected and retrieves its price.
- `CalcPriceOfToppings()`: Iterates through checked topping CheckBoxes and aggregates their prices.
- `GetTotalPrice()`: Sums the results of the above three methods.
- `UpdatePrice()`: Formats total price into currency layout and updates the UI label.

### UI Update System
The UI summary section updates triggered by `CheckedChanged` events.
- `UpdateSizeLabel(object sender)`: Casts the sender to a RadioButton and updates the Size summary label.
- `UpdateCurstTypeLabel(object sender)`: Casts the sender to a RadioButton and updates the Crust summary label.
- `UpdateToopingsLabel()`: Iterates through the selected toppings and concatenates their text into a comma-separated string to display in the Toppings summary label.
- `UpdateEatStatusLabel(object sender, EventArgs e)`: Updates whether the order is for dine-in or take-out.

### State Management
- `SetAllControlsToDefaultValues()`: Sets the default pizza configuration (Small, Thin Crust, Eat-In, no extra toppings).
- `DisableGroups()` / `EnableGroups()`: Toggles the `Enabled` state of the GroupBoxes (Size, Crust, Toppings, WhereToEat) to lock or unlock user inputs.

### Event Handling
- **Form Load**: Initializes default configurations via `SetAllControlsToDefaultValues()`.
- **CheckedChanged Events**: Every time a selection changes, it triggers the corresponding summary update method and recalculates the total price.
- **btnOrderPizza_Click**: Shows a confirmation dialog. If confirmed, UI groups are disabled, order confirmation is shown, and the reset button is enabled.
- **btnResetForm_Click**: Confirms resetting of the form. If confirmed, UI groups are re-enabled, selections are reset to default, and the order button is re-enabled.

## Prerequisites
- .NET Framework 4.8.1
- Visual Studio (or any compatible C# IDE supporting Windows Forms)

## Usage
1. Build and run the solution.
2. Select your desired pizza size, crust type, and add custom toppings.
3. Select whether the order is "Eat In" or "Take Out".
4. Review the auto-generated total price and order summary.
5. Click "Order Pizza" to confirm and lock the order.
6. Click "Reset Form" to start a new order.
