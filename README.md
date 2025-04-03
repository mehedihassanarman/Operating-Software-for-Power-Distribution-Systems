# Operating Software for Power Distribution Systems
This project is a **custom-built operating software** developed to support a **Generation-Based Load Management System**, designed to **prevent nationwide blackouts** like the one that occurred in Bangladesh in 2014. The software was developed using Microsoft Visual Studio and provides a comprehensive interface to monitor, control, and respond to real-time changes in both power generation and load demand across a simulated national grid.The primary goal of this software is to ensure grid stability by automatically balancing electricity demand with available supply. It does this by monitoring live data from each power plant and load area, and adjusting load distribution in real time. Operators can initialize the system by manually connecting power plants; the software then automatically links the appropriate load areas based on each plant’s capacity.

![Normal Operation Mode.png](https://github.com/mehedihassanarman/Operating-Software-for-Power-Distribution-Systems/blob/main/Project%20Image/Normal%20Operation%20Mode.png)

Under normal operation, the software displays current generation from all active power plants, the demand in each load area, and system frequency. Data is received either via GSM-based communication or server connections. The software also features an operation panel that shows the overall status of the grid, load distribution, and a dedicated Load & Frequency Panel to visualize frequency changes and power allocation in real time.

When a power station fails, the system detects it immediately and alerts the operator using a voice notification system. It then calculates how much of the total load must be reduced to maintain frequency stability. For example, if 1500 MW of generation is lost, the system will reduce 37.5% of the load. If two stations go down (2500 MW lost), it will reduce 62.5% of the load. The grid remains operational as long as at least one power plant is still delivering electricity.

If all generation stations fail, the software triggers a full red alert, disconnects all load areas, and system frequency drops to 0 Hz—indicating a complete blackout. However, once any plant comes back online, the software initiates recovery mode, reconnecting load areas and restoring the system to normal operation.

The Load & Frequency Panel presents live system frequency, percentage of load reduction, and power distribution across load areas through dynamic graphs. This visual feedback helps operators and researchers understand how the system behaves under different scenarios.

In summary, this operating software acts as the control center for the generation-based load management model. It is especially useful for training, testing, and research in power systems, particularly for developing countries where infrastructure is limited and backup generation reserves are not readily available.



