# .NET MAUI Demo Project

![.NET MAUI](https://img.shields.io/badge/.NET%20MAUI-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![XAML](https://img.shields.io/badge/XAML-0C54C2?style=for-the-badge&logo=xaml&logoColor=white)

## 📱 About This Project

This repository serves as a comprehensive introduction to **.NET MAUI (Multi-platform App UI)**, Microsoft's modern framework for building native cross-platform applications. This demo showcases the fundamental concepts and capabilities of .NET MAUI, demonstrating how a single codebase can target multiple platforms while maintaining native performance and user experience.

## 🚀 What is .NET MAUI?

**.NET MAUI** is the evolution of Xamarin.Forms, extending beyond mobile to embrace desktop platforms. It's a cross-platform framework that allows developers to create native applications for:

- 🤖 **Android** (phones and tablets)
- 🍎 **iOS** (iPhone and iPad)
- 💻 **macOS** (desktop)
- 🪟 **Windows** (desktop and tablets)

All from a **single shared C# and XAML codebase**.

## ⚡ The Power of .NET MAUI

### Single Codebase, Multiple Platforms
Write your application logic, UI, and business rules once, and deploy everywhere. This significantly reduces development time, maintenance costs, and code duplication.

### True Native Performance
Unlike hybrid frameworks that rely on web views, .NET MAUI compiles to native code and uses native controls, ensuring:
- **Fast performance** comparable to platform-specific apps
- **Native look and feel** on each platform
- **Access to platform-specific APIs** and hardware features

### Modern Development Stack
- **C# Language**: Leverage the power of modern C# with async/await, LINQ, and strong typing
- **XAML**: Declarative UI markup for clean, maintainable interfaces
- **.NET 6+**: Built on the latest .NET runtime with excellent performance and library support
- **Hot Reload**: See UI changes instantly without rebuilding

### Unified API Surface
.NET MAUI provides a single API to access platform-specific features:
- Geolocation and GPS
- Accelerometer and sensors
- Camera and media
- File system access
- Notifications
- Connectivity status
- And much more...

## 🏗️ How .NET MAUI Achieves Cross-Platform Magic

### 1. **Abstraction Layer**
.NET MAUI provides a unified abstraction over native platform APIs. When you write code to display a button, MAUI translates it to:
- A native Android `Button` on Android
- A native iOS `UIButton` on iOS
- A native Windows `Button` on Windows
- A native macOS `NSButton` on macOS

### 2. **Handlers Architecture**
.NET MAUI uses a modern "handlers" architecture that maps cross-platform controls to their native counterparts. This ensures:
- **Optimal performance** by using actual native controls
- **Platform consistency** as users see familiar UI elements
- **Customization flexibility** through custom handlers

### 3. **Platform-Specific Code**
While most code is shared, .NET MAUI makes it easy to write platform-specific code when needed:
```csharp
#if ANDROID
    // Android-specific code
#elif IOS
    // iOS-specific code
#elif WINDOWS
    // Windows-specific code
#elif MACCATALYST
    // macOS-specific code
#endif
```

### 4. **Compilation Process**
- **iOS/macOS**: Ahead-of-Time (AOT) compilation to native ARM assembly
- **Android**: Just-in-Time (JIT) or AOT compilation depending on configuration
- **Windows**: Native compilation to optimized machine code

## 📋 Prerequisites

Before running this demo, ensure you have:

- [Visual Studio 2022](https://visualstudio.microsoft.com/) (17.3 or later) with .NET MAUI workload
  - OR [Visual Studio Code](https://code.visualstudio.com/) with C# Dev Kit and .NET MAUI extensions
- [.NET 6 SDK](https://dotnet.microsoft.com/download) or later
- For Android development: Android SDK and Emulator
- For iOS/macOS development: Xcode (macOS only)
- For Windows development: Windows 10/11 SDK

## 🛠️ Getting Started

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/Kerollos-Saad/.NET-MAUI-Demo.git
   cd .NET-MAUI-Demo
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Build the project**
   ```bash
   dotnet build
   ```

### Running the Application

#### Using Visual Studio
1. Open the `.sln` file in Visual Studio 2022
2. Select your target platform from the debug target dropdown
3. Press `F5` or click the "Run" button

#### Using .NET CLI

**For Android:**
```bash
dotnet build -t:Run -f net8.0-android
```

**For iOS (macOS only):**
```bash
dotnet build -t:Run -f net8.0-ios
```

**For Windows:**
```bash
dotnet build -t:Run -f net8.0-windows10.0.19041.0
```

**For macOS (macOS only):**
```bash
dotnet build -t:Run -f net8.0-maccatalyst
```

## 🎯 Project Structure

```
.NET-MAUI-Demo/
├── Platforms/           # Platform-specific code
│   ├── Android/
│   ├── iOS/
│   ├── MacCatalyst/
│   └── Windows/
├── Resources/           # Shared resources
│   ├── Images/
│   ├── Fonts/
│   └── Styles/
├── Views/              # XAML pages
├── ViewModels/         # MVVM ViewModels (if applicable)
├── Models/             # Data models
├── Services/           # Business logic
└── App.xaml            # Application entry point
```

## 🔥 Key Features Demonstrated

- ✅ Cross-platform UI with XAML
- ✅ Platform-specific implementations
- ✅ Resource management (images, fonts, styles)
- ✅ Navigation between pages
- ✅ Data binding fundamentals
- ✅ MVVM pattern implementation
- ✅ Native control integration

## 📚 Learning Resources

### Official Documentation
- [.NET MAUI Documentation](https://docs.microsoft.com/dotnet/maui/)
- [Microsoft Learn - .NET MAUI](https://learn.microsoft.com/training/paths/build-apps-with-dotnet-maui/)

### Community & Support
- [.NET MAUI GitHub Repository](https://github.com/dotnet/maui)
- [.NET MAUI Community Toolkit](https://github.com/CommunityToolkit/Maui)
- [Stack Overflow - .NET MAUI](https://stackoverflow.com/questions/tagged/dotnet-maui)

### Video Tutorials
- [.NET MAUI for Beginners](https://www.youtube.com/playlist?list=PLdo4fOcmZ0oUBAdL2NwBpDs32zwGqb9DY)
- [James Montemagno's YouTube Channel](https://www.youtube.com/c/JamesMontemagno)

## 🤝 Contributing

Contributions are welcome! If you'd like to improve this demo or add new examples:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is open source and available under the [MIT License](LICENSE).

## 👨‍💻 Author

**Kerollos Saad**

- GitHub: [@Kerollos-Saad](https://github.com/Kerollos-Saad)
- Repository: [.NET-MAUI-Demo](https://github.com/Kerollos-Saad/.NET-MAUI-Demo)

## 🌟 Why Choose .NET MAUI?

1. **Productivity**: Write once, run everywhere - dramatically reduce development time
2. **Performance**: Native compilation ensures optimal speed on all platforms
3. **Modern Tooling**: Leverage Visual Studio's powerful debugging, profiling, and design tools
4. **Cost-Effective**: Maintain a single codebase instead of separate teams for each platform
5. **Future-Proof**: Backed by Microsoft with active development and long-term support
6. **Rich Ecosystem**: Access to NuGet packages and extensive .NET libraries
7. **Enterprise Ready**: Proven in production by thousands of applications worldwide

## 📞 Support

If you have questions or run into issues:

- 📫 Open an [issue](https://github.com/Kerollos-Saad/.NET-MAUI-Demo/issues)
- 💬 Start a [discussion](https://github.com/Kerollos-Saad/.NET-MAUI-Demo/discussions)
- 🌐 Check the [.NET MAUI documentation](https://docs.microsoft.com/dotnet/maui/)

---

**⭐ If you find this demo helpful, please consider giving it a star on GitHub!**

*Built with ❤️ using .NET MAUI*
