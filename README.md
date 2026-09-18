# 02 Task Performance 1: Basic Queuing (Part 2)

An expanded multi-window C# Windows Forms application continuing from **02 Laboratory Exercise 1**. This system implements a full three-form cashier queuing cycle: ticket issuing, cashier queue servicing, and a dedicated customer-facing display showing the ticket currently being served.

<img width="1023" height="655" alt="image" src="https://github.com/user-attachments/assets/2a20ea4e-ec2e-455c-b73c-1ee698e3c1a6" />

---

## What's New in Part 2

* **Customer Serving Display (`CustomerView`):** A dedicated display window showing `*Now Serving` to announce the active ticket to customers.
* **Inspection with `Peek()` and `Contains()`:** Reads and verifies the front element of the queue without dequeuing it prematurely.
* **Three-Way Real-Time Synchronization:** All three windows update simultaneously as customers generate numbers and cashiers call next numbers.
* **Consistent Dark Mode Theme:** Clean dark visual styling matching modern software standards across all three windows.

---

## Form Architecture

The complete application is composed of three interconnected forms:

### 1. `QueuingForm` (Customer Ticket Dispenser)
* Acts as the main entry point and startup form.
* Contains `btnCashier` which increments the counter and generates sequential tickets starting at `P - 10001`.
* Enqueues newly generated ticket strings into `CashierClass.CashierQueue`.
* Launches `CashierWindowQueueForm` and `CustomerView` on form load.

### 2. `CashierWindowQueueForm` (Cashier Station)
* Houses the active waiting list within a `ListView` control (`listCashierQueue`).
* Provides a `btnNext` button that calls `Dequeue()` to process and remove the front ticket when their turn is complete.
* Includes `btnRefresh` for manual updates and a background `Timer` (1-second tick) for automatic list refreshing.

### 3. `CustomerView` (Now Serving Monitor)
* Features large, readable text controls (`lblServingTitle` and `lblNowServing`) to display the active ticket.
* Uses a `Timer` to continuously check the queue state.
* Validates queue status using a single condition and applies `Peek()` and `Contains()` to render the front ticket in real time.

---

## Data Structure & Methods Used

* **`Queue<T>` (`System.Collections.Generic`):** First-In, First-Out (FIFO) collection handling the order of transactions.
* **`Enqueue(T item)`:** Adds new ticket numbers to the end of the queue (`QueuingForm`).
* **`Dequeue()`:** Removes and returns the item at the front of the queue (`CashierWindowQueueForm`).
* **`Peek()`:** Returns the front item without removing it from the queue (`CustomerView`).
* **`Contains(T item)`:** Checks whether the specified ticket value exists inside the queue (`CustomerView`).

---

## Setup & Running the Project

1. Open the existing solution (`.sln`) in **Visual Studio 2015 or higher**.
2. Ensure the project contains the following source files:
   * `CashierClass.cs`
   * `QueuingForm.cs` & `QueuingForm.Designer.cs`
   * `CashierWindowQueueForm.cs` & `CashierWindowQueueForm.Designer.cs`
   * `CustomerView.cs` & `CustomerView.Designer.cs`
   * `Program.cs`
3. Build the solution using `Ctrl + Shift + B`.
4. Press `F5` to launch.
5. All three windows will open:
   * Click **Cashier** on `QueuingForm` to generate tickets (`P - 10001`, `P - 10002`, etc.).
   * Observe `CustomerView` immediately display the ticket currently at the front of the line (`*Now Serving`).
   * Click **Next** on `CashierWindowQueueForm` to complete the transaction and advance the next customer in line.
