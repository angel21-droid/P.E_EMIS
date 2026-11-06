# PE Sports Equipment Monitoring & Inventory System (EMIS)

**PE Sports Equipment Monitoring and Inventory System (EMIS)** is a dedicated desktop management information system engineered for Alegria’s School PE Department to digitize and automate sports asset management. Built with a user-friendly interface, the system features role-based authentication for admins and staff, real-time dashboard analytics, complete inventory tracking with condition and category tagging, and a streamlined borrowing and return workflow tied to student profiles. Additionally, it includes an integrated reporting engine capable of filtering and printing detailed audits for inventory stock, active loans, overdue returns, and damaged items, effectively replacing manual logbooks with an efficient, data-driven system.

---

## 🚀 Key Features

* **🔐 Security & User Management:** Role-based access control supporting `ADMIN` and `STAFF` privilege levels with account maintenance features.
* **📊 Dashboard Analytics:** Real-time summary stat cards for *Total Equipment*, *Available*, *Borrowed*, and *Damaged / Lost* assets along with live transaction activity.
* **📦 Equipment Inventory Management:** Categorize items (Ball Sports, Net Sports, etc.), monitor condition status, total vs. available stock quantities, acquisition dates, and remarks.
* **🔄 Borrowing & Return System:** Process student borrow requests using custom transaction codes, track expected vs. actual return dates, record return conditions, and automatically update item availability.
* **👨‍🎓 Student Directory:** Track student profiles by LRN, full name, grade level, and section for quick linking to equipment transaction logs.
* **📑 Report Generation & Printing:** Filtered reporting for *Equipment Inventory List*, *Borrowing Records Report*, *Overdue Items Report*, and *Damaged / Lost Report* with print preview functionality.

---

## 🛠️ Built With

* **Front-End / UI:** Windows Forms (.NET Framework)
* **Programming Language:** Visual Basic .NET (VB.NET)
* **Database Management System:** Microsoft SQL Server / MySQL *(Update according to your backend)*
* **IDE:** Microsoft Visual Studio

---

## 🖥️ System Interface Previews

| Login Module | System Dashboard |
| :---: | :---: |
| ![Login Form](screenshots/login.png) | ![Dashboard Form](screenshots/dashboard.png) |

| Equipment Inventory | Borrowing Records |
| :---: | :---: |
| ![Inventory Form](screenshots/inventory.png) | ![Borrowing Form](screenshots/borrowing.png) |

| Student Management | Reports & Printing |
| :---: | :---: |
| ![Student Form](screenshots/students.png) | ![Reports Form](screenshots/reports.png) |

---

## ⚙️ Getting Started

### Prerequisites
* [Microsoft Visual Studio](https://visualstudio.microsoft.com/) (2019 or newer recommended)
* .NET Framework 4.7.2 or higher
* Database Server (SQL Server / MySQL)

### Installation & Setup
1. **Clone the repository:**
   ```bash
   git clone https://github.com/your-username/pe-sports-emis.git
   ```
2. **Setup the Database:**
   * Import the database script located in the `database/` folder into your SQL DBMS server.
3. **Configure Project:**
   * Open `PESportsEMIS.sln` in Visual Studio.
   * Update the Connection String inside `App.config` or your connection module with your local server credentials.
4. **Build and Run:**
   * Press `F5` or click **Start** in Visual Studio to launch the application.

---

## 📝 License
This project is open-source and available under the [MIT License](LICENSE)
