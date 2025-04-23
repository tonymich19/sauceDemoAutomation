# SauceDemoTest 🧪🛒

## Background

This solution is a test automation project built using **C#**, **SpecFlow**, and **Selenium WebDriver**. It leverages the **Page Object Model** design pattern to promote code reuse and maintainability.

The tests are designed to validate critical functionalities of the website [https://www.saucedemo.com](https://www.saucedemo.com), a popular platform used for practicing QA automation.

### Tech Stack
- .NET Core 6.0
- SpecFlow
- Selenium WebDriver
- NUnit
- Page Object Model (POM)

---

## Installation

1. Clone this repository.
2. Open the solution in **Visual Studio 2022+**.
3. Install required NuGet packages (SpecFlow, Selenium, NUnit).
4. Make sure `SpecFlow for Visual Studio` is installed from the **Extensions Manager**.

---

## Running the Tests

- Use the **Test Explorer** in Visual Studio to build and run the tests.
- Right-click on individual tests or features to run them selectively, or run the entire test suite.
- All scenarios are independent and can run in any order.

---

## 🔍 Test Coverage

This project currently automates and verifies the following critical user flows:

### ✅ Critical Scenarios

1. **Valid Login**  
   Ensures a valid user can log into the platform.

2. **Invalid Login**  
   Verifies error handling when incorrect credentials are used.

3. **Add Items to Cart**  
   Tests that multiple items (e.g., backpack, t-shirt, jacket) can be added successfully.

4. **Checkout Process**  
   Confirms a user can proceed to checkout with items in the cart.

5. **Logout Functionality**  
   Ensures the user can log out and be redirected to the login page.

---

## Page Object Model

- All page interactions are abstracted into classes under the `PageObjects` folder.
- Step definitions reference these page classes, keeping the BDD layer clean and business-focused.

---

## Living Documentation

The project supports SpecFlow's **LivingDoc** for generating readable documentation directly from the feature files.

### Installation

```bash
dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI
```

### Generate Living Documentation

```bash
livingdoc test-assembly bin\Debug\net6.0\sauceDemoTest.dll -t bin\Debug\net6.0\TestExecution.json
```

---

## Author

**Tony Correia** - 2025  
💻 QA Engineer | Automation Specialist