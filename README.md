# Operating Software for Power Distribution Systems

![Normal Operation Mode.png](https://github.com/mehedihassanarman/Operating-Software-for-Power-Distribution-Systems/blob/main/Project%20Image/Normal%20Operation%20Mode.png)



---

## 📘 Project Overview

This project is a **custom-built operating software** developed to support a **Generation-Based Load Management System**, designed to **prevent nationwide blackouts** like the one that occurred in Bangladesh in 2014.

Built using **Microsoft Visual Studio**, the software provides a complete simulation interface to monitor, control, and respond to fluctuations in **power generation and load demand** across a simulated national grid.

---

## 🎯 Key Objectives

- Simulate power system operation under normal and fault conditions
- Automatically control and adjust loads in response to generation capacity
- Provide **real-time monitoring**, **visual alerts**, and **voice notifications** for operators
- Maintain system frequency near the nominal value (e.g., 50 Hz)

---

## 🧠 Core Features

### 🔧 Initialization Mode
- Operators manually connect power plants
- Load areas connect **automatically** based on plant availability
- The system initializes and synchronizes generation-load mappings

### ⚙️ Normal Operation Mode
- Continuously displays:
  - Live generation output of each power plant
  - Load demand and consumption of 8 defined load zones
  - System frequency and load distribution status
- Data collected via **GSM-based** or **server-based** communication channels

### ⚠️ System Failure Detection & Recovery
- Real-time detection of generation failure (e.g., plant offline)
- **Voice alert system** notifies operator continuously until recovery
- Automatically **reduces load** to match current available generation:
  - 1500 MW lost → ~37.5% load shed
  - 2500 MW lost → ~62.5% load shed
- System stays online as long as **at least one power plant is running**

### 🛑 Total System Failure Mode
- If all plants fail simultaneously:
  - Load areas are disconnected
  - Red alert is displayed
  - System frequency drops to 0 Hz

### 🔄 Back Online Mode
- System restores normal operations once at least one power plant comes back online
- Loads are reconnected, and system frequency stabilizes back to 50 Hz

### 📊 Load & Frequency Panel
- Shows:
  - Current frequency value
  - Real-time load demand
  - Graphs for:
    - Frequency with/without model
    - Load reduction percentage
    - Power distribution across load areas

---

## 🛠️ Built With

- **Microsoft Visual Studio**
- GUI and logic components using C# / .NET
- Real-time simulation and visualization components
- Voice alert integrations for fault detection
- Graphical plotting modules for system behavior tracking

---

## 🌍 Why This Project Matters

This software brings together **simulation and visualization** to form a powerful tool for power grid operators and researchers. It can be used to:

- Train operators in grid fault response
- Test load balancing algorithms
- Understand frequency behavior under various grid conditions
- Simulate **low-resource environments** where backup power reserves are not available

---

> ⚡ This project complements the hardware/model simulation by providing a real-time interface for operation, monitoring, and recovery — creating a complete solution for power grid reliability and blackout prevention.

