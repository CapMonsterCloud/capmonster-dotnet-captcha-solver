# CapMonster Cloud .NET SDK: C# CAPTCHA Solver & Anti-Bot API Client

<p align="center">
  <a href="https://capmonster.cloud/en/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme">
    <img src="https://img.shields.io/badge/CapMonster%20Cloud-.NET%20Captcha%20Solver-00B2FF?style=for-the-badge&logo=dotnet&logoColor=white" alt="CapMonster Cloud .NET SDK" height="40">
  </a>
</p>

<p align="center">
  <strong>Official asynchronous C# / .NET client for automated CAPTCHA solving in web scraping, browser automation, and testing workflows.</strong>
</p>

<p align="center">
  <a href="https://www.nuget.org/packages/Zennolab.CapMonsterCloud.Client/"><img src="https://img.shields.io/nuget/v/Zennolab.CapMonsterCloud.Client.svg?style=flat-square&color=blue" alt="NuGet Version"></a>
  <a href="https://www.nuget.org/packages/Zennolab.CapMonsterCloud.Client/"><img src="https://img.shields.io/nuget/dt/Zennolab.CapMonsterCloud.Client.svg?style=flat-square&color=green" alt="NuGet Downloads"></a>
  <a href="https://github.com/CapMonsterCloud/capmonster-dotnet-captcha-solver/stargazers"><img src="https://img.shields.io/github/stars/CapMonsterCloud/capmonster-dotnet-captcha-solver?style=flat-square&color=yellow" alt="GitHub Stars"></a>
  <a href="https://github.com/CapMonsterCloud/capmonster-dotnet-captcha-solver/network/members"><img src="https://img.shields.io/github/forks/CapMonsterCloud/capmonster-dotnet-captcha-solver?style=flat-square" alt="GitHub Forks"></a>
  <a href="./LICENSE"><img src="https://img.shields.io/badge/License-MIT-orange.svg?style=flat-square" alt="License: MIT"></a>
</p>

---

Official .NET client library for [CapMonster Cloud](https://capmonster.cloud/en/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme). Integrate automated CAPTCHA recognition into **C#, ASP.NET, WPF, Selenium, and browser automation** projects using an asynchronous API client.

The service supports popular CAPTCHA and anti-bot task types, including **reCAPTCHA v2/v3/Enterprise, Cloudflare Turnstile, GeeTest, DataDome, Amazon WAF, Imperva, and image-to-text tasks**.

**[👉 Get your Free API Key & Free Trial Balance on CapMonster Cloud](https://dash.capmonster.cloud/Account/SignUp?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme)**

---

## ⚡ Highlights

- ⚡ **Async-first API:** Use `async` / `await` through `SolveAsync` for scalable .NET automation.
- 🧩 **Modern CAPTCHA coverage:** Work with reCAPTCHA, Turnstile, GeeTest, Amazon WAF, DataDome, Imperva, and more.
- 🌐 **Automation-ready:** Designed for browser automation, scraping, testing, and backend workflows.
- 🛡️ **Proxy support:** Send proxy settings with task types that require browser-session matching.
- 📖 **Official API docs:** Supported task specifications and methods are maintained in the CapMonster Cloud documentation.

---

## 📦 Installation

Install via the NuGet Package Manager:

```powershell
Install-Package Zennolab.CapMonsterCloud.Client
```

Or install through the .NET CLI:

```bash
dotnet add package Zennolab.CapMonsterCloud.Client
```

---

## 🚀 Quick Start

### 1. Initialize the Client

Create an API key in the [CapMonster Cloud Dashboard](https://dash.capmonster.cloud/Account/SignUp?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme), then initialize the client:

```csharp
using Zennolab.CapMonsterCloud.Client;
using Zennolab.CapMonsterCloud.Client.Options;
using Zennolab.CapMonsterCloud.Client.Requests;

var clientOptions = new ClientOptions
{
    ClientKey = "YOUR_CAPMONSTER_CLOUD_API_KEY"
};

var cmCloudClient = CapMonsterCloudClientFactory.Create(clientOptions);
```

### 2. Solve reCAPTCHA v2 with a Proxy

```csharp
var recaptchaV2Request = new RecaptchaV2Request
{
    WebsiteUrl = "https://lessons.zennolab.com/captchas/recaptcha/v2_simple.php?level=high",
    WebsiteKey = "6Lcg7CMUAAAAANphynKgn9YAgA4tQ2KI_iqRyTwd",
    Proxy = new ProxyContainer(
        "203.0.113.45",
        8080,
        ProxyType.Http,
        "login",
        "password")
};

var result = await cmCloudClient.SolveAsync(recaptchaV2Request);
Console.WriteLine($"Solved token: {result.Solution.GRecaptchaResponse}");
```

### 3. Submit a Custom WAF Task

Use custom-task request models for supported advanced protection systems. Consult the [supported CAPTCHA task documentation](https://docs.capmonster.cloud/docs/captchas/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme) for required payload fields and the task type that matches your integration.

```csharp
var tspdRequest = new TspdCustomTaskRequest(
    tspdCookie: "TS386a400d029=...",
    htmlPageBase64: "PCFET0NU...k+PC9odG1sPg==")
{
    WebsiteUrl = "https://yourwebsite.com/page-with-tspd",
    Proxy = new ProxyContainer(
        "203.0.113.45",
        8080,
        ProxyType.Http,
        "login",
        "password")
};

var result = await cmCloudClient.SolveAsync(tspdRequest);
```

---

## 🛡️ Supported Task Families

See the official [Supported CAPTCHA Types](https://docs.capmonster.cloud/docs/captchas/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme) for current task parameters, response formats, and API examples.

| Task family | Example request classes in this SDK |
| :--- | :--- |
| **reCAPTCHA** | `RecaptchaV2Request`, `RecaptchaV2EnterpriseRequest`, `RecaptchaV3ProxylessRequest` |
| **Cloudflare Turnstile** | `TurnstileRequest` |
| **GeeTest** | `GeeTestRequest` |
| **Amazon WAF** | `AmazonWafRequest` |
| **Image-to-Text** | `ImageToTextRequest` |
| **Complex image tasks** | `RecaptchaComplexImageTaskRequest`, `RecognitionComplexImageTaskRequest` |
| **Custom anti-bot tasks** | `DataDomeCustomTaskRequest`, `ImpervaCustomTaskRequest`, `TspdCustomTaskRequest`, and other supported custom-task classes |

---

## 🛠️ How It Works

```text
[ .NET Application / Browser Automation ]
                    │
                    ▼
      [ Create request model with task data ]
                    │
                    ▼
[ CapMonster Cloud .NET SDK ] ──► createTask API request
                    │
                    ▼
      [ SolveAsync polls for task result ]
                    │
                    ▼
[ Receive token / solution ] ──► Use it in your authorized workflow
```

---

## ⚙️ Best Practices

- **Use the right task type:** Choose the task model that matches the target protection and follow the required parameters in the official documentation.
- **Keep browser context consistent:** When a task requires a proxy, use a compatible proxy configuration for the associated automation session.
- **Act on results promptly:** CAPTCHA tokens can expire; submit or inject them immediately after receiving the response.
- **Check balance and errors:** Use the API methods documentation for `getBalance`, task creation, and task-result handling.

---

## 📚 Documentation & Support

- 📖 [Getting Started](https://docs.capmonster.cloud/docs/getting-start/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme)
- 🧩 [Supported CAPTCHA Types](https://docs.capmonster.cloud/docs/captchas/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme)
- ⚙️ [API Methods: createTask, getTaskResult, getBalance](https://docs.capmonster.cloud/docs/methods/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme)
- 🌐 [Browser Extension Guides](https://docs.capmonster.cloud/docs/extension/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme)
- 💬 [CapMonster Cloud](https://capmonster.cloud/en/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme)

---

## 📄 License

[MIT](./LICENSE) © [ZennoLab](https://zennolab.com/) / [CapMonster Cloud](https://capmonster.cloud/en/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme)
