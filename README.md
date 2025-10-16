

---

# 🧮 Floating Point Number Validator (Length ≤ 60) — C# Windows Forms App

A simple **C# Windows Forms Application** built in **Visual Studio 2022** that validates **floating-point numbers** using **Regular Expressions**.
This project only accepts **float values** whose total length is **not greater than 60 characters**, and rejects integers or character inputs.

---

## 🚀 Features

* ✅ Accepts **floating-point numbers** (e.g., `12.34`, `-0.5e+10`, `.5`)
* ❌ Rejects **integers**, **characters**, or any non-float text
* ⚠️ Rejects any float with total length **> 60 characters**
* 💬 Displays valid floats in a separate output box
* 🪟 User-friendly GUI built with **Windows Forms**

---

## 🧠 Regular Expression Used

```regex
^(?=.{1,60}$)[+-]?[0-9]*[.][0-9]+([eE][+-]?[0-9]+)?$
```

### Explanation

| Component            | Meaning                                       |
| -------------------- | --------------------------------------------- |
| `(?=.{1,60}$)`       | Ensures total string length ≤ 60              |
| `[+-]?`              | Optional sign (+ or –)                        |
| `[0-9]*[.][0-9]+`    | Decimal format (e.g., `3.14`, `.5`)           |
| `([eE][+-]?[0-9]+)?` | Optional scientific notation (e.g., `1.2e-3`) |
| `^...$`              | Matches the entire string                     |

---

## 🧩 Example Inputs

| Input                                                               | Result                              |
| ------------------------------------------------------------------- | ----------------------------------- |
| `12.34`                                                             | ✅ Valid Float                       |
| `.5`                                                                | ✅ Valid Float                       |
| `-0.5e+10`                                                          | ✅ Valid Float                       |
| `123`                                                               | ❌ Invalid (integer)                 |
| `'a'`                                                               | ❌ Invalid (character)               |
| `123456789012345678901234567890123456789012345678901234567890.1234` | ❌ Invalid (too long)                |
| `5.`                                                                | ❌ Invalid (no digits after decimal) |

---

## 🧮 Code Snippet

```csharp
Regex floatRegex = new Regex(@"^(?=.{1,60}$)[+-]?[0-9]*[.][0-9]+([eE][+-]?[0-9]+)?$");

foreach (string word in words)
{
    Match match = floatRegex.Match(word);

    if (match.Success)
        textBox2.AppendText(word + " → Valid Float" + Environment.NewLine);
    else
        MessageBox.Show("Invalid (not a valid float or too long): " + word);
}
```

---

## 🖥️ How It Works

1. User enters **space-separated values** in `TextBox1`.
2. On **Validate** button click:

   * Each value is matched against the float regex.
   * Valid floats appear in `TextBox2`.
   * Invalid values trigger a message box.

---

## ⚙️ Project Setup

1. Open **Visual Studio 2022**.
2. Create a new **Windows Forms App (.NET Framework or .NET 6)** project.
3. Add:

   * `textBox1` → Input field
   * `textBox2` → Output field
   * `button1` → Validate button
4. Replace `Form1.cs` code with the provided version.
5. Run (`F5`) and test.

---

## 📂 Project Structure

```
📦 WinFormsApp1
 ┣ 📜 Form1.cs
 ┣ 📜 Form1.Designer.cs
 ┣ 📜 Program.cs
 ┗ 📜 README.md
```

---

## 💡 Future Improvements

* Add **error reasons** (e.g., “Too long”, “Invalid format”).
* Highlight invalid inputs in red instead of using pop-ups.
* Extend to support integers, chars, or other data types.

---

## 🧑‍💻 Author

**Muhammad Haseeb**


---


