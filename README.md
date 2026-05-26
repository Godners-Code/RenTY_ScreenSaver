<div align="center">
  <h1>RenTY ScreenSaver</h1>
  
  **一款优雅、现代且信息丰富的 Windows 屏幕保护程序**

  ![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)
  ![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white)
  ![Windows](https://img.shields.io/badge/Windows-0078D4?logo=windows&logoColor=white)
  [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
  
  ![RenTY ScreenSaver Preview](RTYSS.jpg)
</div>

## ✨ 项目介绍

RenTY ScreenSaver 是一款专为追求**简洁美学**与**实用信息**结合而设计的 Windows 屏幕保护程序。它不仅能有效保护屏幕，还能在待机时为你展示丰富且美观的实时信息。

采用纯 .NET 8 开发，轻量高效，色彩动态变化，适合长时间显示。

## 🌟 主要特性

- **多显示器完美支持**  
  自动检测并适配所有连接的显示器，每个屏幕独立运行且色彩不同步
- **动态 HSV 色彩系统**  
  根据当前时间实时生成柔和互补色，色彩自然过渡，永不重复
- **丰富的信息展示**  
  - 大字体日期 + 星期中文显示
  - 毫秒级精确时间（HH:mm:ss.ff）
  - 当前时区信息
  - 屏幕编号与实时分辨率
- **智能响应式布局**  
  自动识别横屏/竖屏，根据屏幕分辨率动态调整字体大小与间距
- **极简现代设计**  
  使用等宽字体 `Consolas`，信息层级清晰，视觉舒适
- **高 DPI 与高分辨率支持**  
  完美兼容 2K、4K、超宽屏等现代显示器
- **资源占用极低**  
  纯 Windows Forms 实现，内存与 CPU 占用极小

## 📸 效果预览

![RenTY ScreenSaver Preview](RTYSS.jpg)

*动态色彩变化 + 丰富信息展示界面*

## 🚀 安装与使用

### 方法一：推荐安装方式

1. 下载最新 Release 中的 `RenTY ScreenSaver.scr` 文件
2. 右键点击该文件 → 选择 **安装**
3. 打开 Windows 设置 → **个性化** → **锁屏** → **屏幕保护程序设置**
4. 选择 `RenTY ScreenSaver` 并点击 **应用**

### 方法二：从源码编译

```bash
git clone https://github.com/Godners-Code/RenTY_ScreenSaver.git
cd RenTY_ScreenSaver
```

使用 Visual Studio 2022 或更高版本打开 `RenTY_ScreenSaver.sln`，切换到 **Release** 配置生成即可得到 `.scr` 文件。

## 🛠️ 技术细节

### 项目架构

- **开发语言**：C#
- **框架**：.NET 8.0 Windows Forms
- **目标平台**：Windows 10 / 11 (64位)

### 核心模块

| 文件              | 功能说明                              |
|-------------------|---------------------------------------|
| `Program.cs`      | 程序入口、多显示器管理、命令行参数处理 |
| `WinSS.cs`        | 单个屏幕的窗体逻辑与绘制             |
| `Clr.cs`          | HSV 色彩转换、动态互补色生成算法     |
| `Str.cs`          | 字符串格式化、星期中文转换、动态字体计算 |
| `Scr.cs`          | 显示器信息封装类（Screen Wrapper）   |

### 关键技术实现

- **色彩算法**：基于 HSV 色相环，根据当前秒数映射色相，实现平滑互补色变化
- **字体适配**：根据屏幕实际像素尺寸与显示内容长度，动态计算最佳字体大小（支持横屏/竖屏）
- **多显示器支持**：使用 `Screen.AllScreens` 为每个显示器创建独立窗体，实现独立色彩与信息显示
- **毫秒级时间**：使用 `DateTime.Now` + `String.Format` 实现精确到百分秒的显示
- **响应式布局**：实时监听屏幕尺寸变化，自动调整控件位置与字体

## 📋 支持的命令行参数

| 参数 | 功能             | 说明                  |
|------|------------------|-----------------------|
| `/s` | 正常运行         | 标准屏幕保护模式      |
| `/p` | 预览模式         | 在设置窗口中预览      |
| `/c` | 设置界面         | 当前版本暂未实现      |

## 🎯 设计理念

RenTY ScreenSaver 不只是一个普通的屏保，它融合了**信息美学**与**动态艺术**。在保护 OLED/AMOLED 屏幕的同时，为用户提供实用且优雅的视觉体验。

## 📄 许可证

本项目采用 **MIT License** 开源协议 —— 欢迎自由使用、修改与分发。

---

**Copyright © 2026 Godners Ren (Godners-Code)**  
**https://github.com/Godners-Code/RenTY_ScreenSaver**
```
