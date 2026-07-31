# C# Captcha Solver & Anti-Bot Bypass SDK | CapMonster Cloud

[![NuGet Version](https://img.shields.io/nuget/v/Zennolab.CapMonsterCloud.Client.svg?style=flat-square)](https://www.nuget.org/packages/Zennolab.CapMonsterCloud.Client/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Zennolab.CapMonsterCloud.Client.svg?style=flat-square)](https://www.nuget.org/packages/Zennolab.CapMonsterCloud.Client/)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square)](https://opensource.org/licenses/MIT)

Official C# / .NET client library for the [CapMonster Cloud](https://capmonster.cloud/) automated captcha recognition service. 

This SDK empowers developers to easily integrate high-speed, API-based captcha solving into their C#, WPF, and ASP.NET web scraping, automation, and testing projects. We provide seamless bypass for classic captchas (reCAPTCHA, FunCaptcha) as well as complex WAF and anti-bot systems (Cloudflare Turnstile, DataDome, Imperva).

🚀 **[Create an account and get your API Key today!](https://dash.capmonster.cloud/Account/SignUp?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme)**

## ⚡ Key Features
- **High Success Rate & Speed:** Solves complex captchas in milliseconds.
- **WAF Bypass:** Built-in support for DataDome, Cloudflare, Amazon WAF, and more.
- **Easy Integration:** Ready-to-use C# models for all modern challenge types.
- **Async/Await Support:** Fully asynchronous API for high-performance, multi-threaded scraping.

---

## ⚙️ Installation

Install the CapMonster Cloud C# client via **NuGet Package Manager**:

```bash
Install-Package Zennolab.CapMonsterCloud.Client
```

Or via the **.NET CLI**:

```bash
dotnet add package Zennolab.CapMonsterCloud.Client
```

---

## 🚀 Quick Start & Usage Examples

To start solving captchas, you need a CapMonster Cloud API key. If you don't have one, [register here](https://dash.capmonster.cloud/Account/SignUp?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme).

### 1. Initialization

```csharp
using Zennolab.CapMonsterCloud.Client;
using Zennolab.CapMonsterCloud.Client.Options;
using Zennolab.CapMonsterCloud.Client.Requests;

var clientOptions = new ClientOptions
{
    ClientKey = "<your capmonster.cloud API key>"
};

var cmCloudClient = CapMonsterCloudClientFactory.Create(clientOptions);
```

### 2. How to Solve reCAPTCHA v2 (With Proxy)
*Using a proxy is highly recommended for web scraping to avoid IP bans.*

```csharp
var recaptchaV2ProxyRequest = new RecaptchaV2Request
{
    WebsiteUrl = "https://lessons.zennolab.com/captchas/recaptcha/v2_simple.php?level=high",
    WebsiteKey = "6Lcg7CMUAAAAANphynKgn9YAgA4tQ2KI_iqRyTwd",
    Proxy = new ProxyContainer("203.0.113.45", 8080, ProxyType.Http, "login", "password")
};

var recaptchaV2ProxyResult = await cmCloudClient.SolveAsync(recaptchaV2ProxyRequest);
Console.WriteLine($"Solved Token: {recaptchaV2ProxyResult.Solution.GRecaptchaResponse}");
```

### 3. How to Bypass WAF (e.g., TSPD, DataDome, Castle)
*For sites protected by advanced anti-bot challenges, use our CustomTask requests.*

```csharp
var tspdRequest = new TspdCustomTaskRequest(
    tspdCookie: "TS386a400d029=08...010245; TS386a400d029=08...01a06e; TS386a400d078=08...dbb3b0c; TSd2153684027=08...1944",
    htmlPageBase64: "PCFET0NU...k+PC9odG1sPg==")
{
    WebsiteUrl = "https://yourwebsite.com/page-with-tspd",
    Proxy = new ProxyContainer("203.0.113.45", 8080, ProxyType.Http, "login", "password")
};

var tspdResult = await cmCloudClient.SolveAsync(tspdRequest);
```

---

## 🧩 Supported Captcha Recognition Requests

Our .NET client supports automated recognition for almost all modern anti-bot challenges. Click on the links below to view detailed documentation for each specific task.

### Classic Captcha Tasks (Tokens)
- [AmazonWafRequest](https://zenno.link/doc-amazon-waf) - Amazon WAF Bypass
- [BinanceTaskRequest](https://zenno.link/doc-binance) - Binance Captcha Solver
- [FunCaptchaRequest](https://zenno.link/doc-funcaptcha) - Arkose Labs FunCaptcha
- [GeeTestRequest](https://zenno.link/doc-geetest) - GeeTest v3 & v4
- [ImageToTextRequest](https://zenno.link/doc-imagetotext) - Standard OCR (Image-to-Text)
- [MTCaptchaTaskRequest](https://zenno.link/doc-mtcaptcha)
- [ProsopoTaskRequest](https://zenno.link/doc-prosopo)
- [RecaptchaV2Request](https://zenno.link/doc-recaptcha2) - Google reCAPTCHA v2
- [RecaptchaV2EnterpriseRequest](https://zenno.link/doc-recaptcha2e)
- [RecaptchaV3ProxylessRequest](https://zenno.link/doc-recaptcha3) - Google reCAPTCHA v3
- [TurnstileRequest - Cloudflare Turnstile](https://zenno.link/doc-cloudflare-turnstile) - Cloudflare Turnstile Solver
- [TurnstileRequest - Cloudflare Challenge](https://zenno.link/doc-cloudflare-challenge)
- [TurnstileRequest - Cloudflare Waiting Room](https://zenno.link/doc-cloudflare-waitingroom)
- [YidunTaskRequest](https://zenno.link/doc-yidun)

### Custom Tasks (Anti-Bot / WAF / Custom Challenge Systems)
- [AlibabaCustomTaskRequest](https://zenno.link/doc-customtask-alibaba)
- [AltchaCustomTaskRequest](https://zenno.link/doc-customtask-altcha)
- [BasiliskCustomTaskRequest](https://zenno.link/doc-customtask-basilisk)
- [DataDomeCustomTaskRequest](https://zenno.link/doc-customtask-datadome) - DataDome Slider & Interstitial bypass
- [FriendlyCustomTaskRequest](https://zenno.link/doc-customtask-friendly)
- [HuntCustomTaskRequest](https://zenno.link/doc-customtask-hunt)
- [ImpervaCustomTaskRequest](https://zenno.link/doc-customtask-imperva) - Imperva / Incapsula bypass
- [TenDiCustomTaskRequest](https://zenno.link/doc-customtask-tendi)
- [TspdCustomTaskRequest](https://zenno.link/doc-customtask-tspd)

### Complex Image Tasks (Grid / Dynamic Image Selection)
- [RecaptchaComplexImageTaskRequest](https://zenno.link/doc-complextask-rc)
- [RecognitionComplexImageTaskRequest](https://zenno.link/doc-complextask-recognition)

---

## 📚 Documentation & Support

For comprehensive guides, advanced scraping techniques, API limits, and error handling, please visit our official documentation:

📖 **[CapMonster Cloud Official Documentation](https://docs.capmonster.cloud/)**  
💬 **[Support / Contact Us](https://capmonster.cloud/)**
