# ⚡ PHY-LIB

[![License: MPL-2.0](https://img.shields.io/badge/License-MPL_2.0-brightgreen.svg)](https://opensource.org/licenses/MPL-2.0)
[![C#](https://img.shields.io/badge/C%23-.NET%207%2B-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Status](https://img.shields.io/badge/Status-Active_Development-orange.svg)]()
[![AI Blocked](https://img.shields.io/badge/AI-Blocked-red.svg)]()

*A lightweight C# library providing core abstractions, helpers, and utilities to streamline routine development tasks.*

---

## 🎯 About The Project

**PHY-LIB** is a modular collection of developer utilities, wrappers, and core abstractions designed to eliminate boilerplate code in C# applications. 

Whether you are setting up Discord bots, working with asynchronous file IO, or utilizing lightweight mathematical types, this library provides simple, clean, and reusable interfaces to accelerate your workflow.

---

## 📂 Project Structure

```text
PHY-LIB/
│
├── Bots/                           # Bot frameworks and platform integrations
│   └── DiscordBots/
│       └── D#+/                    # DSharpPlus wrappers & client initialization helpers
│           ├── Client/             # Client setup and command registration
│           └── Data/               # Configuration data contracts & readers
│
├── Maths/                          # Basic math structures and helper types
│   ├── vec3.cs                     # Generic 3D Vector implementation
│   └── mat4.cs                     # 4x4 Matrix implementation
│
├── .gitignore
├── LICENSE
└── PHY_LIB.csproj

## 🚀 Key Features

* **Discord Bot Helpers:** Simplified bot setup and command registration using DSharpPlus.
* **Data Reading & Serialization:** Asynchronous file reading abstractions (`IDataReader`).
* **Math Primitives:** Lightweight generic vector and matrix structures for routine calculations.
* **Zero Overhead:** Minimal external dependencies for clean integration into any .NET project.

---

## 🛡️ Strict "No AI" Policy

> **ATTENTION!**  
> This repository maintains a strict **100% human-crafted code** policy. No neural networks, AI code generators, or LLM-assisted code synthesis are used. Every single line of code, optimization, and architecture decision is written and verified by hand.

---

## 📄 License

Distributed under the **MPL-2.0 License**. See `LICENSE` for more information.
