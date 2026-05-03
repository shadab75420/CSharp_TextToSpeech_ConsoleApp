# C# Text-to-Speech Console Application

## Problem Statement

This project implements a simple Text-to-Speech (TTS) application using C#.
The program takes text input from the user and converts it into spoken audio using the system’s speech engine.

---

## Features

* Accepts user input from console
* Converts text into speech
* Uses built-in speech synthesis library
* Simple and interactive console-based application

---

## Technologies Used

* C#
* .NET Framework / .NET
* `System.Speech.Synthesis` library

---

## Functionality Overview

* The user enters text through the console
* The program uses `SpeechSynthesizer` to process the text
* The system reads the text aloud through speakers

---

## Code Structure

* `Program.cs` → Main application logic
* `SpeechSynthesizer` → Handles text-to-speech conversion

---

## Sample Output

Enter text: Hello world
Speech output: "Hello world"

---

## How to Run the Code

1. Open the project in Visual Studio
2. Ensure `.NET Framework` is selected (required for System.Speech)
3. Add reference:

   * `System.Speech` (if not already added)
4. Build the project
5. Run the program (Ctrl + F5 or F5)
6. Enter text and hear the output

---

