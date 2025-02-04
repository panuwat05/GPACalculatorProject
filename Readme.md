GPAXCalculator Project by Panuwat Prasertdee 673450474-0 IS KKU61
![image](https://github.com/user-attachments/assets/52d3a29d-10d9-4e66-9122-e38821f8cfe5)

 
 # GPAX Calculator

This is a Windows Forms application that calculates the cumulative GPA (GPAX). It allows users to input GPA values and keeps track of the maximum, minimum, and average GPAs. The application includes input validation and a UI to display the results.

---

## 📌 Class Diagram

```mermaid
classDiagram
    direction TB
    class Form1 {
        - GPACalculator gpaCalculator
        + Form1()
        + void btData_Click(object sender, EventArgs e)
        + void btClear_Click(object sender, EventArgs e)
        + void UpdateUI()
    }

    class GPACalculator {
        - List<double> gpaList
        + GPACalculator()
        + void setGPA(double gpa)
        + double getGPAX()
        + double getMaxGPA()
        + double getMinGPA()
        + int getStudentCount()
    }

    Form1 --> GPACalculator : "Uses"
