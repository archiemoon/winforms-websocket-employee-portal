Employee Portal Application – A-Level Computer Science Project

This repository contains my A-Level Computer Science project: a full **Employee Portal desktop system** built using **C# WinForms**, backed by a **WebSocket-based live messaging server**, and integrated with a **MySQL database** for secure data storage.

The project includes:
- Real-time communication between employees
- Shift management controlled by users with a manager role
- Secure login system with a **custom hashing algorithm**
- A full 150+ page Word/PDF report covering research, design, development, interviews, and evaluation (included in `/docs`)

---

## Project Overview

The Employee Portal was designed to simulate a workplace communication and scheduling system. The software allows employees to interact, view and pick up shifts, and send instant messages through a custom WebSocket server.

### **Key Functionalities**

#### **1. User Authentication**
- Username + password login  
- Passwords stored in MySQL  
- Custom hashing algorithm using **XOR and ASCII manipulation**  
- Secure verification against the stored hash  

#### **2. Real-Time Messaging System**
- Built with a **handmade WebSocket server**  
- Users can chat live inside the portal  
- Server handles multiple connections  
- Supports persistent message broadcasts

#### **3. Shift Management**
- Managers can create and upload new shifts  
- Employees can pick up available shifts  
- Permissions and roles stored in the database  
- Automatic UI updates and data refreshes  

#### **4. MySQL Database Integration**
- Stores account details, roles, and shift information  
- Uses parameterized queries to prevent SQL injection  
- Includes ER diagrams and database design in documentation  

---

## Features Summary

- ✔ C# WinForms front-end  
- ✔ Custom-built WebSocket backend server  
- ✔ Live chat + instant communication  
- ✔ Role-based access (Employee vs Manager)  
- ✔ MySQL database for persistent storage  
- ✔ Secure login with custom password hashing  
- ✔ Shift scheduling and pickup system  
- ✔ Extensive design + development documentation  
